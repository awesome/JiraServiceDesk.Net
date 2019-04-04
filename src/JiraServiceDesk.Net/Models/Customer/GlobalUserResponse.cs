using System.Collections.Generic;

namespace JiraServiceDesk.Net.Models.Customer
{
    // https://stackoverflow.com/questions/38752168/parsing-from-json-to-object-using-flurl#38752253
    public class GlobalUserResponse
    {
        public IList<GlobalUser> Data { get; set; }  
    }
}