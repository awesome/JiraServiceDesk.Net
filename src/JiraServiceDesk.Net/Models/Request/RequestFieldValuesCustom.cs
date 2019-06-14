﻿using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://jira.sebrands.com/browse/COACH-1921
    // https://developer.atlassian.com/cloud/jira/service-desk/rest/#fieldformats
    public class RequestFieldValuesCustom : RequestFieldValues
    {
        public string Customfield12430 { get; set; }
        public string Customfield12431 { get; set; }
        public string Customfield12424 { get; set; }
        public string Customfield12434 { get; set; }
        public string Customfield12803 { get; set; }
        public string Customfield12432 { get; set; }
        public string Customfield12433 { get; set; }
        public string Customfield12437 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield12427 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield12421 { get; set; }
        public RequestFieldValuesCustomNestedId Customfield12423 { get; set; }
    }
}