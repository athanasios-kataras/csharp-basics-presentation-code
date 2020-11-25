using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Adapter
{
    public class InvestmentProduct
    {
        public string Name {get; set;}
        public Dictionary<string, decimal> RateDetails {get; set;}
    }
}