using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype.Models;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype
{
    public interface IOfferingsCalculator
    {
        Dictionary<int, BetSlip> GetOfferings();
    }
}