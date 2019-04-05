namespace JiraServiceDesk.Net.Models.Customer.Mappers
{
    public static class GlobalUserMapper
    {
        public static GlobalUser MapIt(Customer customer)
        {
            return new GlobalUser
            {
                Self = customer.Links.Self,
                Key = customer.Key,
                AccountId = customer.AccountId,
                // AccountType - does not convert 
                Name = customer.Name,
                EmailAddress = customer.EmailAddress,
                AvatarUrls = customer.Links.AvatarUrls,
                DisplayName = customer.DisplayName,
                Active = customer.Active,
                TimeZone = customer.TimeZone,
                // Locale - does not convert
            };
        }
    }
}