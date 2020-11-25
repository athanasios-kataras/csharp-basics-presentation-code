using Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    /// <summary>
    /// This is the invoker object in the command pattern
    /// </summary>
    public class QueueClient
    {
        private CommandQueue commandQueue;
        public void ProcessQueue() {
            while(true) {
                ITransactionCommand command = commandQueue.GetCurrent();
                command.ExecuteCommand();
            }
        }
    }
}