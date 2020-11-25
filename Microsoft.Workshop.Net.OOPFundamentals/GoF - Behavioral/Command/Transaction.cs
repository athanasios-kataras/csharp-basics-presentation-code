namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    public class Transaction
    {

        public Product FromProduct {get; set;}
        public Product ToProduct {get; set;}

        public decimal Amount {get; set;}

        public bool ExecuteTransaction()
        {
            FromProduct.Balance -= Amount;
            ToProduct.Balance += Amount;
            FromProduct.PostChanges();
            ToProduct.PostChanges();
            return true;
        }

        public bool UndoTransaction()
        {
            FromProduct.Balance += Amount;
            ToProduct.Balance -= Amount;
            FromProduct.PostChanges();
            ToProduct.PostChanges();
            return true;
        }
        public bool BindTransaction()
        {
            // Do something with the date
            return true;
        }
    }
}