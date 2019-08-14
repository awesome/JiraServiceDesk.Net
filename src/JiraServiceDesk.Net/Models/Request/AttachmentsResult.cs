using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // "AttachmentResult" v3.16.1 response 
    // https://docs.atlassian.com/jira-servicedesk/REST/3.16.1/#servicedeskapi/request/{issueIdOrKey}/attachment 
    public class AttachmentsResult
    {
        public Comment Comment { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}