using System;
using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype.Models;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Prototype
{
    public class BetOfferingsRepository
    {
        private static Dictionary<int,BetSlip> OfferingsBetSlips { get; set;}

        private IOfferingsCalculator OfferingsCalculator {get; set;}

        public BetOfferingsRepository(IOfferingsCalculator offeringsCalculator) {
           this.OfferingsCalculator = offeringsCalculator;
        }

        /// <summary>
        /// The referenced item will be changed by the consumer
        /// </summary>
        /// <param name="id">The id of the offerings</param>
        /// <returns>A new clone of the betslip to be changed by the consumer</returns>
        public BetSlip GetByOfferingId(int id) {
            if (OfferingsBetSlips == null) {
                PopulateOfferings();
            }
            return (BetSlip)OfferingsBetSlips[id].Clone();
        }

        private void PopulateOfferings()
        {
            OfferingsBetSlips = OfferingsCalculator.GetOfferings();
        }
    }
}