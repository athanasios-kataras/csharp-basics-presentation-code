using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Bridge
{
    public abstract class Product {
        public Product(ITransactionService transactionService) {
            this.transactionService = transactionService;
        }
        public int ProductId {get; set;}

        protected decimal balance;
        public abstract decimal Balance {get;set;}
        protected ITransactionService transactionService;
    }
    public class Account : Product
    {
        public Account(ITransactionService transactionService) : base(transactionService)
        {
        }

        public override decimal Balance {get {return this.balance;}
        set {
            if (value < 0) {
                if(this.transactionService.DebitProduct(this.ProductId, value)) {
                    this.balance -= value;
                }
            } else if (value > 0){
                if(this.transactionService.CreditProduct(this.ProductId, value)) {
                    this.balance += value;
                }
            } else {
                throw new ArgumentException();
            }
        }}
    }

    public class Card : Product
    {
        public Card(ITransactionService transactionService) : base(transactionService)
        {
        }
        public override decimal Balance {get;set;}

    }

    public class Loan : Product
    {
        public Loan(ITransactionService transactionService) : base(transactionService)
        {
        }
        public override decimal Balance {get;set;}

    }
}