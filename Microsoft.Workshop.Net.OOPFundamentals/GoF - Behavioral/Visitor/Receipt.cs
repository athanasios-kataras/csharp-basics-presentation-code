namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public interface IReceipt
    {
        void Accept(IReceiptVisitor visitor);
    }
}