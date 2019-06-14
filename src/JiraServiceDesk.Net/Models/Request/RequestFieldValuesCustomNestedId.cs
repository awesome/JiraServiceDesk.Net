using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Request
{
    // https://jira.sebrands.com/browse/COACH-1921
    // https://github.com/anytimefitness/anytime-fitness-android/blob/7dbc5f589dcac51694d4cfee2dc4da98c33c3e23/app/src/main/java/com/anytimefitness/app/jsdsdk/JsdClient.kt#L76
    public class RequestFieldValuesCustomNestedId
    {
        public string Id { get; set; }
    }
}