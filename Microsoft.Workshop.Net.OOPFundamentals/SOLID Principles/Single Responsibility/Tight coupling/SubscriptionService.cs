namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Single_Responsibility.Tight_coupling
{
    public class SubscriptionService
    {
        public bool Create(string email, string password) {
            var emailService = new EmailService();
            // ... Create subscription ... //
            emailService.SendAsync = true;
            emailService.SendEmail("Subscription created", "Success");
            return true;
        }
    }
}