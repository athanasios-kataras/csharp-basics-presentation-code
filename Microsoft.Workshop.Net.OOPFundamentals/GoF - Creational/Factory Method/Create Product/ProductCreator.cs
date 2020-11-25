using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method.Create_Product.InvestmentProducts;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Factory_Method
{
    public abstract class ProductCreator
    {
        /// <summary>
        /// This is the FACTORY method (hence the name)
        /// </summary>
        /// <param name="productDetails">A dictionary with data</param>
        /// <returns>The specific flavor of the Investment product</returns>
        protected abstract InvestmentProduct CreateProduct(Dictionary<string, string> productDetails);

        public bool RegisterProduct(Dictionary<string, string> productDetails) {
            var investmentProduct = this.CreateProduct(productDetails);
            investmentProduct.Register();
            // Tasks to add to client profile
            return true;
        }
    }
}