using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators.Products;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators
{
    public interface IProductFactory
    {
        Product createFromProduct(string fromProductCode);
        Product createToProduct(string fromProductCode);
    }
}