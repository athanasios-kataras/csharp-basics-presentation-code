using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Proxy
{
    public interface IProductTypeRepository
    {
        List<ProductType> GetProductTypes();
    }
}