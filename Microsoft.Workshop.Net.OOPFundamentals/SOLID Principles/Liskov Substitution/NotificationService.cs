namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Liskov_Substitution
{

    public interface INotificationService
    {
        void SendText();
        void SendEmail();
    }

    public class SmtpNotificationService : INotificationService
    {
        public void SendEmail()
        {
            /// <summary>
            /// Sending Emails
            /// </summary>
        }

        public void SendText()
        {
            throw new System.NotImplementedException();
        }
    }
}