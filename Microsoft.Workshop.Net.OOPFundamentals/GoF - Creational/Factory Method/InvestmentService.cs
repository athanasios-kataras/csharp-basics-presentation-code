using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method
{
    public class ProductService
    {
        public bool CreateInvestmentProduct(int type, string sessionId, Dictionary<string, string> productDetails) {
            ProductCreator productCreator;
            if (type == 1) {
                productCreator = new BondCreator();
            } else {
                productCreator = new StockCreator();
            }

            return productCreator.RegisterProduct(productDetails);
        }
    }
}