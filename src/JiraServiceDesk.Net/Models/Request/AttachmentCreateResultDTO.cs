using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Request
{
    // declared type "AttachmentCreateResultDTO"
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#api-rest-servicedeskapi-request-issueIdOrKey-attachment-post
    // https://docs.atlassian.com/jira-servicedesk/4.2.0/com/atlassian/servicedesk/api/rest/dto/domain/attachment/AttachmentCreateResultDTO.html
    public class AttachmentCreateResultDTO
    {
        public Comment Comment { get; set; }
        public PagedResults<Attachment> Attachments { get; set; }
    }
}
