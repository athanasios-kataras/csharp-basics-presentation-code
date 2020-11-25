namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands
{
    public class ExecuteTransactionCommand : ITransactionCommand
    {
        Transaction transaction;
        public ExecuteTransactionCommand(Transaction transaction)
        {
            this.transaction = transaction;
        }
        public bool ExecuteCommand()
        {
            return transaction.ExecuteTransaction();
        }
    }
}