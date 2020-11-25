namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Interface_Segregation
{
    public interface INotificationService: IEmailNotificationService, ISMSNotificationService
    {
        
    }

    public class AllNotificationsService : INotificationService
    {
        public void SendEmail()
        {
            /// <summary>
            /// Sending Emails
            /// </summary>
        }

        public void SendText()
        {
            /// <summary>
            /// Sending SMS
            /// </summary>
        }
    }
}