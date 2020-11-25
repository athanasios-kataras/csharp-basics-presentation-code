using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Proxy
{
    public class ProductTypesRepository : IProductTypeRepository
    {
        public List<ProductType> GetProductTypes()
        {
            // Change this line to get from service or database
            List<ProductType> productTypes = new List<ProductType>();

            return productTypes;
        }
    }
}