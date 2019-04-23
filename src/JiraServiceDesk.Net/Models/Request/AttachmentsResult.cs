using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#api-rest-servicedeskapi-request-issueIdOrKey-attachment-post
    public class AttachmentsResult
    {
        public Comment Comment { get; set; }
        public PagedResults<Attachment> Attachments { get; set; }
    }
}
