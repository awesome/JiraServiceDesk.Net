using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://jira.sebrands.com/browse/COACH-1921
    public class CustomerRequestCustom
    {
        public string ServiceDeskId { get; set; }
        public string RequestTypeId { get; set; }
        public RequestFieldValuesCustom RequestFieldValuesCustom { get; set; }
        public string RaiseOnBehalfOf { get; set; }
        public List<string> RequestParticipants { get; set; }
    }
}
