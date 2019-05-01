using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#fieldformats
    public class RequestFieldValues
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Attachment { get; set; }
    }
}