namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Bridge
{
    public class TransferService
    {
        public bool ExecuteIntrabankTrasfer(int debitProductId, int debitProductType, int creditProductId, int creditProductType, decimal amount) {
            Product fromProduct;
            Product toProduct;
            if(debitProductType == 1) {
                fromProduct = new Account(new IntrabankService()) {
                    ProductId = debitProductId
                };
            } else if(debitProductType == 2) {
                fromProduct = new Card(new IntrabankService()) {
                    ProductId = debitProductId
                };
            } else {
                fromProduct = new Loan(new IntrabankService()) {
                    ProductId = debitProductId
                };
            }

            if(creditProductType == 1) {
                toProduct = new Account(new IntrabankService()) {
                    ProductId = creditProductId
                };
            } else if(creditProductType == 2) {
                toProduct = new Card(new IntrabankService()) {
                    ProductId = creditProductId
                };
            } else {
                toProduct = new Loan(new IntrabankService()) {
                    ProductId = creditProductId
                };
            }

            fromProduct.Balance -= amount;
            toProduct.Balance += amount;

            return true;
        }
    }
}