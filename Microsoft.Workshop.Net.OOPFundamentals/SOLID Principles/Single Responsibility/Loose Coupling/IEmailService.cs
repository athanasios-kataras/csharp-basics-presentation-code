namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Single_Responsibility.Loose_Coupling
{
    public interface IEmailService
    {
        bool SendEmail(string topic, string body);
        bool SendEmailAsync(string topic, string body);
    }
}