namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands
{
    public class UndoTransactionCommand : ITransactionCommand
    {
        Transaction transaction;
        public UndoTransactionCommand(Transaction transaction)
        {
            this.transaction = transaction;
        }

        public bool ExecuteCommand()
        {
            return transaction.UndoTransaction();
        }
    }
}