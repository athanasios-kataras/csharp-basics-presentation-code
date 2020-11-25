using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product.InvestmentProducts
{
    public class StockProduct : InvestmentProduct
    {
        public StockProduct(Dictionary<string,string> productDetails)
        {
            // Communicate with investment services
            // Get the data
        }

        public override bool Register()
        {
            // Do stuff to create and register the product
            // in the stocks database/system
            return true;
        }
    }
}