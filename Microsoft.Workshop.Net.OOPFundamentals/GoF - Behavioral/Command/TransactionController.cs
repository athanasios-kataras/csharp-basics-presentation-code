using Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    /// <summary>
    /// This is the client object in the command pattern
    /// </summary>
    public class TransactionController
    {
        public bool PostIntrabank(Transaction transaction)
        {
            var queue = new CommandQueue();
            var command = new ExecuteTransactionCommand(transaction);
            return queue.Add(command);
        }

        public bool UndoIntrabank(Transaction transaction)
        {
            var queue = new CommandQueue();
            var command = new UndoTransactionCommand(transaction);
            return queue.Add(command);
        }

        public bool BindIntrabank(Transaction transaction)
        {
            var queue = new CommandQueue();
            var command = new BindTransactionCommand(transaction);
            return queue.Add(command);
        }
    }
}