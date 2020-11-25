using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abastract_Factory.Transaction_Example
{
    public class TransactionService
    {
        public bool ExecuteTransaction(TransactionType type, string fromProductCode, string toProductCode, decimal amount) {
            IProductFactory productFactory;
            if (type == TransactionType.AccountToAccount) {
                productFactory = new AccountToAccountFactory();
            }
            else {
                productFactory = new AccountToCardFactory();
            }
            var fromProduct = productFactory.createFromProduct(fromProductCode);
            var toProduct = productFactory.createToProduct(toProductCode);

            if (fromProduct.Balance < amount) return false;

            fromProduct.Balance -= amount;
            toProduct.Balance += amount;

            return true;
        }
    }
}