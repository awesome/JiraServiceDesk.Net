using System;

namespace JiraServiceDesk.Net.Models.Common
{
    public class JiraServiceDeskDate
    {
        // […] DateTimeOffset values are much more common than those for DateTime values. As a result, DateTimeOffset
        // should be considered the default date and time type for application development.
        // https://docs.microsoft.com/en-us/dotnet/standard/datetime/choosing-between-datetime
        public DateTimeOffset? Iso8601 { get; set; }
        public DateTimeOffset? Jira { get; set; }
        public string Friendly { get; set; }
        public long EpochMillis { get; set; }
    }
}
