using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor
{
    public class PrintingVisitor : IReceiptVisitor
    {
        public void Execute(RetailReceipt r)
        {
            Console.WriteLine("Printing retail receipt");
        }

        public void Execute(SupplierReceipt r)
        {
            Console.WriteLine("Printing supplier receipt");
        }
    }
}