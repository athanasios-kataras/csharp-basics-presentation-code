using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product.InvestmentProducts;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product
{
    public class StockCreator : ProductCreator
    {
        public StockCreator()
        {
        }

        protected override InvestmentProduct CreateProduct(Dictionary<string, string> productDetails)
        {
            return new StockProduct(productDetails);
        }
    }
}