namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Single_Responsibility.Tight_coupling
{
    public class EmailService
    {
        public bool SendAsync {get; set;}
        public bool SendEmail(string topic, string body) {
            if (SendAsync) {
                // ... Send email asynch .. //
            } else {
                // ... Send email synch .. //
            }
            return true;
        }
    }
}