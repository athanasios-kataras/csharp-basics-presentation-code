using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public class ReceiptPrinter
    {
        public void ExportReceipts() {
            List<IReceipt> receipts = new List<IReceipt>();
            receipts.Add(new RetailReceipt());
            receipts.Add(new SupplierReceipt());
            var receiptVisitor = new PrintingVisitor();
            receipts.ForEach(_ => _.Accept(receiptVisitor));
        }
    }
}