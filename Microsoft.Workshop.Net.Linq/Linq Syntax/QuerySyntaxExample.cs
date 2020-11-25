using System;
using System.Collections.Generic;
using System.Linq;
namespace Microsoft.Workshop.Net.Linq.Linq_Syntax
{
    public class QuerySyntaxExample
    {
        #region Create data sources

        List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}, MainDistributor = "Scaboo"},
            new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}, MainDistributor = ""},
            new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}, MainDistributor = ""},
            new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}, MainDistributor = ""},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}, MainDistributor = ""},
            new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}, MainDistributor = "Scaboo"},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}, MainDistributor = ""},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}, MainDistributor = ""},
            new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}, MainDistributor = "Bascoo"},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}, MainDistributor = ""},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}, MainDistributor = ""},
            new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}, MainDistributor = ""}
        };

        List<Distributor> distributors = new List<Distributor>
        {
            new Distributor {Name = "Edgepulse", State = "UT"},
            new Distributor {Name = "Jabbersphere", State = "GA"},
            new Distributor {Name = "Quaxo", State = "FL"},
            new Distributor {Name = "Yakijo", State = "OR"},
            new Distributor {Name = "Scaboo", State = "GA"},
            new Distributor {Name = "Bascoo", State = "GA"},
            new Distributor {Name = "Innojam", State = "WA"},
            new Distributor {Name = "Edgetag", State = "WA"},
            new Distributor {Name = "Leexo", State = "HI"},
            new Distributor {Name = "Abata", State = "OR"},
            new Distributor {Name = "Vidoo", State = "TX"}
        };

        double[] exchange = { 0.89, 0.65, 120.29 };
        #endregion

        #region From/Select Examples
        public void SelectAsNewType()
        {
            var custPurQuery =
                from c in customers
                from p in c.Purchases
                select new { Name = c.Last, Purchase = p };

            foreach (var cust in custPurQuery)
            {
                Console.WriteLine("{0}, {1}", cust.Name, cust.Purchase);
            }
        }
        #endregion

        #region Where Examples
        public void Query()
        {
            IEnumerable<Customer> filteredCustomers =
                from cust in this.customers
                where cust.State == "OR"
                select cust;

            foreach (var cust in filteredCustomers)
            {
                System.Console.WriteLine(cust.ToString());
            }
        }
        public void WhereExamples()
        {
            IEnumerable<Customer> filteredCustomers =
                from cust in this.customers
                where cust.State == "OR"
                select cust;

            filteredCustomers =
            from cust in this.customers
            where cust.State == "OR" && cust.Purchases.Count() > 0
            where cust.Price >= 2000
            select cust;
        }
        #endregion

        #region Ordering Examples
        public void ExecuteOrderingExamples()
        {
            var queryOregonCustomersByPrice =
                from cust in customers
                where cust.State == "GA"
                orderby cust.Price ascending
                select cust;
            
            foreach(var cust in queryOregonCustomersByPrice) {
                Console.WriteLine("Price: {0} - Name: {1}", cust.Price, cust.First + "-" + cust.Last);
            }

            var queryOregonCustomersByPriceDesc =
                from cust in customers
                where cust.State == "GA"
                orderby cust.Price descending
                select cust;

            var queryOregonCustomersByPriceMulti =
                from cust in customers
                where cust.State == "GA"
                orderby cust.Price descending, cust.Purchases.Count()
                select cust;
        }
        #endregion

        #region Group By Examples
        public void GroupBy()
        {
            var groupbystate =
                from cust in customers
                group cust by cust.State;

            foreach (var grouping in groupbystate)
            {
                Console.WriteLine("State: {0}", grouping.Key);
                foreach (var customer in grouping)
                {
                    Console.WriteLine("Customer: {0} {1}", customer.First, customer.Last);
                }
            }
        }

        public void GroupByPrice()
        {
            var groupbystate =
                from cust in customers
                group cust by cust.Price > 1000;

            foreach (var grouping in groupbystate)
            {
                Console.WriteLine("Price: {0}", grouping.Key);
                foreach (var customer in grouping)
                {
                    Console.WriteLine("Customer: {0} {1}", customer.First, customer.Last);
                }
            }
        }
        #endregion

        #region Join Examples
        public void ExecuteInnerJoin()
        {
            var result =
                from cust in customers
                join dist in distributors
                    on cust.State equals dist.State
                select new { CustName = cust.First + "" + cust.Last, DistName = dist.Name };

            foreach (var res in result)
            {
                Console.WriteLine("Customer Name: {0} - Distributor Name: {1}", res.CustName, res.DistName);
            }
        }

        public void ExecuteGroupJoin()
        {
            var result =
                from cust in customers
                join dist in distributors
                    on cust.State equals dist.State into custdist
                select custdist;

            foreach (var res in result)
            {
                foreach (var dist in res)
                {
                    Console.WriteLine("Distributor Name: {0}", dist.Name);
                }
            }
        }

        public void ExecuteGroupJoinWithClass()
        {
            var result =
                from dist in distributors
                join cust in customers
                    on dist.State equals cust.State into custDist
                select
                    new
                    {
                        distName = dist.Name,
                        custs = custDist.Select(x => new { CustName = x.First + " " + x.Last })
                        // custs = custDist
                    };

            foreach (var dist in result)
            {
                Console.WriteLine("Distributor Name: {0}", dist.distName);
                foreach (var cust in dist.custs)
                {
                    Console.WriteLine(" Customer: {0}", cust.CustName);
                    // Console.WriteLine(" Customer: {0}", cust.First + " " + cust.Last);
                }
            }
        }

        public void ExecuteLeftOuterJoin()
        {
            var result =
                from dist in distributors
                join cust in customers
                    on dist.State equals cust.State into distCust
                from dc in distCust.DefaultIfEmpty()
                select
                    new
                    {
                        distName = dist.Name,
                        custsName = dc == null ? "Empty" : dc.First + " " + dc.Last
                    };

            foreach (var res in result)
            {
                Console.WriteLine("Customer Name: {0} - Distributor Name: {1}", res.custsName, res.distName);
            }
        }
        #endregion

        #region Let Keyword
        public void ExecuteJoinWithLet()
        {
            var result =
                from dist in distributors
                let mainDistributorStates = new List<string> { "TX", "OR" }
                from mdist in mainDistributorStates
                where dist.State == mdist
                select dist;

            // result =
            //     from dist in distributors
            //     let mainDistributorStates = new List<string> {"TX", "OR"}
            //     join mdist in mainDistributorStates 
            //         on dist.State equals mdist
            //     select dist;
        }

        public void ExecuteNonEquiJoin()
        {
            var result =
                from dist in distributors
                from cust in customers
                where cust.State == dist.State && cust.MainDistributor == dist.Name
                select cust;

            result =
                from dist in distributors
                join cust in customers
                    on new { State = dist.State, DistName = dist.Name } equals new { State = cust.State, DistName = cust.MainDistributor }
                where cust.State == dist.State && cust.MainDistributor == dist.Name
                select cust;
        }
        #endregion
    }
}