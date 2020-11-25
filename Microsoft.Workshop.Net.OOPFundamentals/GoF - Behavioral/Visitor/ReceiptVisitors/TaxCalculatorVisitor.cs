namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public class TaxCalculatorVisitor : IReceiptVisitor
    {
        public void Execute(RetailReceipt r)
        {
            throw new System.NotImplementedException();
        }

        public void Execute(SupplierReceipt r)
        {
            throw new System.NotImplementedException();
        }
    }
}