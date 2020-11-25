namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands
{
    /// <summary>
    /// This is the Command Interface
    /// </summary>
    public interface ITransactionCommand
    {
         bool ExecuteCommand();
    }
}