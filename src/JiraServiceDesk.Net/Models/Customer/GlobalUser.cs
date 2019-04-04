using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Customer
{   
    // DTO via https://developer.atlassian.com/cloud/jira/platform/rest/v3/#api-rest-api-3-user-search-get
    public class GlobalUser
    {
        public string Self { get; set; }
        public string Key { get; set; }
        public string AccountId { get; set; }
        public string AccountType { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
        public string Locale { get; set; }
    }
}