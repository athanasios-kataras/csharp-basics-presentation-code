using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Proxy
{
    public class ProductTypesClient
    {
        private IProductTypeRepository productTypeProxy;
        public ProductTypesClient() {
            productTypeProxy = new ChachedProductTypesRepository();
        }

        public List<ProductType> GetProductTypes()
        {
            return productTypeProxy.GetProductTypes();
        }
    }
}