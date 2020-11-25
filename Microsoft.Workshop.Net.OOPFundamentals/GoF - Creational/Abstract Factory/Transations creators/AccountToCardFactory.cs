using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators.Products;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators
{
    public class AccountToCardFactory : IProductFactory
    {
        public Product createFromProduct(string fromProductCode)
        {
            return new Account(fromProductCode);
        }

        public Product createToProduct(string toProductCode)
        {
            return new Card(toProductCode);
        }
    }
}