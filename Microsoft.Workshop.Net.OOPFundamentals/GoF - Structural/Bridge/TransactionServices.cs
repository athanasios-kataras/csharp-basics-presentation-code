namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Bridge
{
    public interface ITransactionService {
        bool CreditProduct(int productId, decimal Amount);
        bool DebitProduct(int productId, decimal Amount);
    }

    public class InterbankService : ITransactionService
    {
        public bool CreditProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }

        public bool DebitProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }
    }

    public class IntrabankService : ITransactionService
    {
        public bool CreditProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }

        public bool DebitProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }
    }

    public class InternationalkService : ITransactionService
    {
        public bool CreditProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }

        public bool DebitProduct(int productId, decimal Amount)
        {
            throw new System.NotImplementedException();
        }
    }
}