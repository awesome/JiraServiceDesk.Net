using Newtonsoft.Json;
using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Customer
{   
    // DTO via https://developer.atlassian.com/cloud/jira/platform/rest/v3/#api-rest-api-3-user-search-get
    public class GlobalUser
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}