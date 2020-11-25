namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Single_Responsibility.Loose_Coupling
{
    public class SubscriptionService
    {
        IEmailService emailService;

        public SubscriptionService(IEmailService emailService) {
            this.emailService = emailService;
        }
        
        public bool Create(string email, string password) {
            // ... Create subscription ... //
            emailService.SendEmailAsync("Subscription created", "Success");
            return true;
        }
    }
}