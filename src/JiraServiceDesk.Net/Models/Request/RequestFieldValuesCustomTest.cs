using Newtonsoft.Json;

namespace JiraServiceDesk.Net.Models.Request
{
    // SANDBOX-SEB
    // This class corresponds with custom params listed here: https://sandbox-seb.atlassian.net/rest/servicedeskapi/servicedesk/SD/requesttype/2/field?expand=true
    // Version: https://jira.sebrands.com/secure/attachment/62598/62598_JSD-IDS-test-20190625.txt
    // https://jira.sebrands.com/browse/COACH-1921?focusedCommentId=157473&page=com.atlassian.jira.plugin.system.issuetabpanels:comment-tabpanel#comment-157473
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#fieldformats
    public class RequestFieldValuesCustomTest : RequestFieldValues
    {
        // ClubId
        [JsonProperty("customfield_10036")]
        public string Customfield10036 { get; set; }
        
        // AppName
        [JsonProperty("customfield_10040")]
        public string Customfield10040 { get; set; }
        
        // AppVersion
        [JsonProperty("customfield_10041")]
        public string Customfield10041 { get; set; }
        
        // OsName
        [JsonProperty("customfield_10042")]
        public string Customfield10042 { get; set; }
        
        // OsVersion
        [JsonProperty("customfield_10043")]
        public string Customfield10043 { get; set; }
        
        // DeviceModel
        [JsonProperty("customfield_10044")]
        public string Customfield10044 { get; set; }
        
        // UserId
        [JsonProperty("customfield_10045")]
        public string Customfield10045 { get; set; }
        
        // Keyfob
        [JsonProperty("customfield_10046")]
        public string Customfield10046 { get; set; }
        
        // UserType
        [JsonProperty("customfield_10037")]
        public RequestFieldValuesCustomNestedId Customfield10037 { get; set; }
        
        // AppType
        [JsonProperty("customfield_10038")]
        public RequestFieldValuesCustomNestedId Customfield10038 { get; set; }
        
        // Country
        [JsonProperty("customfield_10039")]
        public RequestFieldValuesCustomNestedId Customfield10039 { get; set; }
    }
}