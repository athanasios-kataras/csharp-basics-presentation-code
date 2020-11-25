namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    public class InterestState : State
    {
        // Overloaded constructors
        public InterestState(State state)
          : this(state.Balance, state.Account)
        {
        }

        public InterestState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database

            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
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
            if (balance < 0.0)
            {
                account.State = new BlockedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new NormalState(this);
            }
        }
    }
}