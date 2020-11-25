using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype.Models
{
    public class BetSlip : ICloneable
    {
        public int Id { get; set; }
        public List<Bet> Bets { get; set; }

        public object Clone()
        {
            var betSlipClone = (BetSlip)this.MemberwiseClone();
            foreach (Bet bet in Bets)
            {
                betSlipClone.Bets.Add((Bet)bet.Clone());
            }
            return betSlipClone;
        }
    }
}