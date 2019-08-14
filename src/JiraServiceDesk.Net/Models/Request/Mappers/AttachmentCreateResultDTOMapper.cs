using JiraServiceDesk.Net.Models.Common;

namespace JiraServiceDesk.Net.Models.Request.Mappers
{
    public static class AttachmentCreateResultDTOMapper
    {
        public static AttachmentCreateResultDTO MapIt(AttachmentsResult result)
        {
            return new AttachmentCreateResultDTO
            {
                Comment = result.Comment,
                Attachments = new PagedResults<Attachment>()
                {
                    Values = result.Attachments
                }
            };
        }
    }
}