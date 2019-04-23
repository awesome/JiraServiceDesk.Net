using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#api-rest-servicedeskapi-request-issueIdOrKey-attachment-post
    public class Attachment : WithLinks
    {
        public string Filename { get; set; }
        public User Author { get; set; }
        public JiraServiceDeskDate Created { get; set; }
        public long Size { get; set; }
        public string MimeType { get; set; }
    }
}