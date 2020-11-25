namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Clean_Code.Naming.Parameters
{
    public class TransferService
    {
        public bool ExecuteTansferFlow(string fromCode, string toCode, decimal amount, string username) { return true; }
        public bool ExecuteTransferFlow(Transfer transfer) { return true; }
    }

    public class Transfer
    {

    }
}