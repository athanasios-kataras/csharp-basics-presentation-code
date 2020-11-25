using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Workshop.Net.Linq.Linq_Syntax
{
    public class MethodSyntaxExample
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

        #region Where Examples
        public void WhereExamples()
        {
            IEnumerable<Customer> filteredCustomers =
                this.customers.Where((c) => c.State == "OR");

            filteredCustomers =
                this.customers
                    .Where((c) => c.State == "OR" && c.Purchases.Count() > 0)
                    .Where((c) => c.Price > 2000);

        }
        #endregion

        #region Group By Examples
        public void GroupBy()
        {
            var groupbystate =
                this.customers.GroupBy(c => c.State);

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
                this.customers.GroupBy(c => c.Price > 1000);

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
            this.customers
                .Join(distributors, 
                        (c) => c.State, 
                        (d) => d.State, 
                        (c,d) => new { 
                            CustName = c.First + "" + c.Last, 
                            DistName = d.Name }
                        );

            foreach (var res in result)
            {
                Console.WriteLine("Customer Name: {0} - Distributor Name: {1}", res.CustName, res.DistName);
            }
        }

        public void ExecuteGroupJoin()
        {
            var result =
                this.customers
                .GroupJoin(distributors, 
                        (c) => c.State, 
                        (d) => d.State, 
                        (c,d) => d
                        );

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
                this.distributors
                .GroupJoin(customers, 
                        (d) => d.State, 
                        (c) => c.State, 
                        (d,c) =>  new
                    {
                        distName = d.Name,
                        custs = c.Select(x => new { CustName = x.First + " " + x.Last })
                    }
                );

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
                this.distributors
                .GroupJoin(customers, 
                        (d) => d.State, 
                        (c) => c.State, 
                        (d,c) =>  new
                    {
                        Dist = d,
                        Custs = c
                    }
                )
                .SelectMany(
                    d => d.Custs.DefaultIfEmpty(),
                    (d,c) => new {distName = d.Dist.Name, custsName = c == null ? "Empty" : c.First + " " + c.Last}
                );

            foreach (var res in result)
            {
                Console.WriteLine("Customer Name: {0} - Distributor Name: {1}", res.custsName, res.distName);
            }
        }
        #endregion
    
        #region Extention Methods
        public void ExecuteAggregateExample() {
            var result =
                this.customers
                    .Aggregate(0d, (c, next) => next.Price + c);
            

            var result2 =
                this.customers
                    .Sum(c => c.Price);
            
            Console.WriteLine("Total price aggregate:" + result);
            Console.WriteLine("Total price sum:" + result2);
        }
        #endregion
    }
}