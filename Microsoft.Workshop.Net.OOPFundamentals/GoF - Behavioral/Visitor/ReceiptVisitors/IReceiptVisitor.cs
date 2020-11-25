namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public interface IReceiptVisitor
    {
        void Execute(RetailReceipt r);
        void Execute(SupplierReceipt r);
    }
}