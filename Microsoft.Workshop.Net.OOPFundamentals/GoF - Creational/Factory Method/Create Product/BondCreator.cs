using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product.InvestmentProducts;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product
{
    public class BondCreator : ProductCreator
    {
        public BondCreator()
        {
        }

        protected override InvestmentProduct CreateProduct(Dictionary<string, string> productDetails)
        {
            return new BondProduct(productDetails);
        }
    }
}