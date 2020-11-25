using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Blocked indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    public class BlockedState : State

    {
        private double _serviceFee;

        // Constructor

        public BlockedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource

            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("The account is blocked!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new NormalState(this);
            }
        }
    }
}