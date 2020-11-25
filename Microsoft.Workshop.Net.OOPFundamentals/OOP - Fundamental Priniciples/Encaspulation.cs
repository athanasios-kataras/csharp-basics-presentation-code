using System;

namespace Microsoft.Workshop.Net.OOPFundamentals
{
    public class BankAccount
    {
        public decimal balance;
        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }
    }


    public class BankAccountEncap
    {
        private decimal holds;
        private decimal grossBalance;

        public DateTime CreationDate { get; protected set; }

        public BankAccountEncap(decimal grossBalance, decimal holds = 0)
        {
            this.grossBalance = grossBalance;
            this.holds = holds;
        }

        public decimal Balance
        {
            get { return this.grossBalance - this.holds; }
            set
            {
                this.grossBalance += value;
                // If it's a deposit, the 1/10 are holds
                if (value > 0)
                {
                    this.holds += value / 10;
                }
            }
        }
    }

    public class Transfer
    {
        private BankAccount fromAccount;
        private BankAccount toAccount;
        private decimal amount;

        public Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.amount = amount;
        }

        public bool Execute()
        {
            if (this.fromAccount.balance > amount)
            {
                return false;
            }
            this.fromAccount.balance -= amount;
            this.fromAccount.balance += amount;

            return true;
        }
    }

    public class Settings
    {
        public string ConnectionString { get; private set; }
        public bool DeleteFiles { get; private set; }

        public void init()
        {
            Settings settings = ReadSettings();

            IProcessor processor =
            new IndexingProcessor(
            new Repository(settings.ConnectionString));

            if (settings.DeleteFiles)
            {
                processor =
                new CompositeProcessor(
                processor,
                new DeleteProcessor());
            }

            processor.Process();
        }

        private Settings ReadSettings()
        {
            throw new NotImplementedException();
        }
    }


}