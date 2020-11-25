using System;
using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Visitor;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural;

namespace Microsoft.Workshop.Net.OOPFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExecutePolymorphismExample();
            // ExecuteGoFCompositeExample();
            ExecuteVisitorExample();
        }

        #region GoF - Visitor Example
        private static void ExecuteVisitorExample()
        {
            var receiptPrinter = new ReceiptPrinter();
            receiptPrinter.ExportReceipts();
        }
        #endregion

        #region Polymorphism
        static void ExecutePolymorphismExample() {
            var polymorphicExtend = new PolymorphicExtend();
            var polymorphicExtendHide = new PolymorphicExtendHide();

            var polymorphicClasses = new List<PolymorphicBase>() {
                polymorphicExtend,
                polymorphicExtendHide
            };

            // PolymorphicExtend as PolymorphicBase
            polymorphicClasses[0].Override();
            polymorphicExtend.Override();
            // PolymorphicExtendHide as PolymorphicBase
            polymorphicClasses[1].Override();
            polymorphicExtendHide.Override();
        }
        #endregion
   
        #region GoF - Composite
            public static void ExecuteGoFCompositeExample() {
                var client = new FileSystemClient();
                client.ShowStructure();
            }
        #endregion
    }
}
