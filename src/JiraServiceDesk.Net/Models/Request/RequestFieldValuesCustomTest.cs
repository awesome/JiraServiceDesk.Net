using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // SANDBOX-SEB
    // This class corresponds with custom params listed here: https://sandbox-seb.atlassian.net/rest/servicedeskapi/servicedesk/SD/requesttype/2/field?expand=true
    // Version: https://jira.sebrands.com/secure/attachment/62598/62598_JSD-IDS-test-20190625.txt
    // https://jira.sebrands.com/browse/COACH-1921?focusedCommentId=157473&page=com.atlassian.jira.plugin.system.issuetabpanels:comment-tabpanel#comment-157473
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#fieldformats
    public class RequestFieldValuesCustomTest : RequestFieldValues
    {
        public string Customfield10036 { get; set; }
        public string Customfield10040 { get; set; }
        public string Customfield10041 { get; set; }
        public string Customfield10042 { get; set; }
        public string Customfield10043 { get; set; }
        public string Customfield10044 { get; set; }
        public string Customfield10045 { get; set; }
        public string Customfield10046 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield10037 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield10038 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield10039 { get; set; }
    }
}