namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Single_Responsibility.Loose_Coupling
{
    public class EmailService: IEmailService
    {
        public bool SendEmail(string topic, string body) {
            // ... Send email synch .. //
            return true;
        }
        
        public bool SendEmailAsync(string topic, string body) {
            // ... Send email asynch .. //
            return true;
        }
    }
}