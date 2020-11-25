using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype.Models
{
    public class Bet: ICloneable
    {
        public string Title;
        public decimal Odds;
        public decimal PlacedBet;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}