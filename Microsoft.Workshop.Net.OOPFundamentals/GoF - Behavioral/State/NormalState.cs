namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Normal indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class NormalState : State
    {
        // Overloaded constructors
        public NormalState(State state) :
          this(state.Balance, state.Account)
        {
        }

        public NormalState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource

            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.State = new BlockedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new InterestState(this);
            }
        }
    }
}