using System.Linq;
using System.Collections.Generic;
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

        // dev notes:
        // https://stackoverflow.com/questions/38752168/parsing-from-json-to-object-using-flurl#38752253
        // issues with GetJsonAsync() for empty type wrapper https://github.com/tmenier/Flurl/issues/288
        // instead using GetJsonListAsync() or ReceiveJson()
        // https://stackoverflow.com/questions/52843606/web-api-call-returns-json-data-with-empty-fields/52856465#52856465
        // https://stackoverflow.com/questions/44566204/flurl-mapping-property-names
        public async Task<IList<GlobalUser>> GetGlobalUserAsync(string emailString)
        {
            return await GetGlobalUserSearchUrl()
                .SetQueryParams(new {username = emailString})
                .GetAsync()
                .ReceiveJson<IList<GlobalUser>>()
                .ConfigureAwait(false);
        }
        
        public async Task<GlobalUser> FindOrCreateGlobalUser(string emailString, string displayName)
        {
            var list = await GetGlobalUserAsync(emailString);
            if (list.Count > 0)
            {
                return list.First();
            }
            else
            {
                var customer = await CreateCustomerAsync(emailString, displayName);
                return GlobalUserMapper.MapIt(customer);
            }
        }
    }
}
