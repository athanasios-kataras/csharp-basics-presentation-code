namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    public class Client
    {
        public void DoWork() {
            var queueClient = new QueueClient();

            queueClient.ProcessQueue();
        }
    }
}