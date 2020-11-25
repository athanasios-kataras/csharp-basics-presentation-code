using System.IO;
using Microsoft.Workshop.Net.OOPFundamentals.Lab.Solid;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Microsoft.Workshop.Net.OOPFundamentals.Lab.UnitTests.Solid
{
    public class RatingEngineRate
    {
        [Test]
        public void ReturnsRatingOf10000For200000LandPolicy()
        {
            var policy = new Policy
            {
                Type = PolicyType.Land,
                BondAmount = 200000,
                Valuation = 200000
            };
            string json = JsonConvert.SerializeObject(policy);
            File.WriteAllText("policy.json", json);

            var engine = new RatingEngine();
            engine.Rate();
            var result = engine.Rating;

            Assert.AreEqual(10000, result);
        }

        [Test]
        public void ReturnsRatingOf0For200000BondOn260000LandPolicy()
        {
            var policy = new Policy
            {
                Type = PolicyType.Land,
                BondAmount = 200000,
                Valuation = 260000
            };
            string json = JsonConvert.SerializeObject(policy);
            File.WriteAllText("policy.json", json);

            var engine = new RatingEngine();
            engine.Rate();
            var result = engine.Rating;

            Assert.AreEqual(0, result);
        }
    }
}