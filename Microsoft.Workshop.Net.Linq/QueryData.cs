using System.Collections.Generic;

namespace Microsoft.Workshop.Net.Linq
{
    #region Class Definitions
    public class Customer
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string State { get; set; }
        public double Price { get; set; }
        public string[] Purchases { get; set; }
        public string MainDistributor {get; set;}
    }

    public class Distributor
    {
        public string Name { get; set; }
        public string State { get; set; }
    }

    public class CustDist
    {
        public string custName { get; set; }
        public string distName { get; set; }
    }

    public class CustDistGroup
    {
        public string custName { get; set; }
        public IEnumerable<string> distName { get; set; }
    }
    #endregion
}