using Newtonsoft.Json;

namespace JiraServiceDesk.Net.Models.Request
{
    // PROD-SEB
    // This class corresponds with custom params for: https://jira.sebrands.com/rest/servicedeskapi/request
    // Version: https://jira.sebrands.com/secure/attachment/62597/62597_JSD-IDS-db615f88370be40111873f410401fd4a947d1d39.txt
    // https://jira.sebrands.com/browse/COACH-1921
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#fieldformats
    public class RequestFieldValuesCustom : RequestFieldValues
    {
        // AppName
        [JsonProperty("customfield_12430")]
        public string Customfield12430 { get; set; }
        
        // AppVersion
        [JsonProperty("customfield_12431")]
        public string Customfield12431 { get; set; }
        
        // ClubId
        [JsonProperty("customfield_12424")]
        public string Customfield12424 { get; set; }
        
        // DeviceModel
        [JsonProperty("customfield_12434")]
        public string Customfield12434 { get; set; }
        
        // Keyfob
        [JsonProperty("customfield_12803")]
        public string Customfield12803 { get; set; }
        
        // OsName
        [JsonProperty("customfield_12432")]
        public string Customfield12432 { get; set; }
        
        // OsVersion
        [JsonProperty("customfield_12433")]
        public string Customfield12433 { get; set; }
        
        // UserId
        [JsonProperty("customfield_12437")]
        public string Customfield12437 { get; set; }
        
        // Country
        [JsonProperty("customfield_12427")]
        public RequestFieldValuesCustomNestedId Customfield12427 { get; set; }
        
        // AppType
        [JsonProperty("customfield_12421")]
        public RequestFieldValuesCustomNestedId Customfield12421 { get; set; }
        
        // UserType
        [JsonProperty("customfield_12423")]
        public RequestFieldValuesCustomNestedId Customfield12423 { get; set; }
        
        //
        // AFW CustomFields; https://jira.sebrands.com/browse/COACH-2004
        //
        // AccessLevel
        [JsonProperty("customfield_12820")]
        public string Customfield12820 { get; set; }
        // PlName
        [JsonProperty("customfield_12818")]
        public string Customfield12818 { get; set; }
        // PlUrl
        [JsonProperty("customfield_12819")]
        public string Customfield12819 { get; set; }
    }
}