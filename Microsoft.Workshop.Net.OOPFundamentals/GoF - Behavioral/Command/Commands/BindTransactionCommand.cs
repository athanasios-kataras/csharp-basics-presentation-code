namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands
{
    public class BindTransactionCommand : ITransactionCommand
    {
        Transaction transaction;
        public BindTransactionCommand(Transaction transaction)
        {
            this.transaction = transaction;
        }
        public bool ExecuteCommand()
        {
            return transaction.BindTransaction();
        }
    }
}