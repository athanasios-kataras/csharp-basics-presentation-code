using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Proxy
{
    public class ChachedProductTypesRepository: IProductTypeRepository
    {
        private List<ProductType> productTypes;
        private IProductTypeRepository productTypeRepository;

        public ChachedProductTypesRepository() {
            this.productTypeRepository = new ProductTypesRepository();
        }

        public List<ProductType> GetProductTypes()
        {
            if(productTypes == null) {
                productTypes = this.productTypeRepository.GetProductTypes();
            }
            return productTypes;
        }
    }
}