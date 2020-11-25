namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public class RetailReceipt : IReceipt
    {
        public void Accept(IReceiptVisitor visitor)
        {
            visitor.Execute(this);
        }
    }
}