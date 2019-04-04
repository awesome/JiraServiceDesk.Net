using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;
using JiraServiceDesk.Net.Models.Customer;
using JiraServiceDesk.Net.Models.Customer.Mappers;

namespace JiraServiceDesk.Net
{
    public partial class JiraServiceDeskClient
    {
        private IFlurlRequest GetCustomerUrl() => GetBaseUrl()
            .AppendPathSegment("/customer");

        private IFlurlRequest GetGlobalUserSearchUrl() => GetBaseUrlJira()
            .AppendPathSegment("/user/search");

        public async Task<Customer> CreateCustomerAsync(string email, string fullName)
        {
            var data = new
            {
                email,
                fullName
            };

            var response = await GetCustomerUrl()
                .PostJsonAsync(data)
                .ConfigureAwait(false);

            return await HandleResponseAsync<Customer>(response).ConfigureAwait(false);
        }

        public async Task<GlobalUserResponse> GetGlobalUserAsync(string emailString)
        {
            return await GetGlobalUserSearchUrl()
                .SetQueryParams(new {username = emailString})
                .GetJsonAsync<GlobalUserResponse>()
                .ConfigureAwait(false);
        }
        
        public async Task<GlobalUser> FindOrCreateGlobalUser(string emailString, string displayName)
        {
            var globalUserResponse = await GetGlobalUserAsync(emailString);
            if (globalUserResponse.Data.Count > 0)
            {
                return globalUserResponse.Data.First();
            }
            else
            {
                var customer = await CreateCustomerAsync(emailString, displayName);
                return GlobalUserMapper.MapIt(customer);
            }

        }
    }
}
