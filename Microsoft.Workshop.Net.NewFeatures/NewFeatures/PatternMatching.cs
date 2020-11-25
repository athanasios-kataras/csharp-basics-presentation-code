namespace Microsoft.Workshop.Net.NewFeatures.NewFeatures
{
    using System;
    public class PatternMatching
    {

    }
    public enum EmployeeType {
        Partial,
        Vendor,
        FullTime
    }
    public class Employee : IComparable
    {
        public EmployeeType Type { get; set; }

        public bool IsThirdPatry => this.Type is EmployeeType.Vendor;
        public String Name { get; set; }
        
        public int Id { get; set; }

        

        public int CompareTo(Object o)
        {
            if (o is Employee e)
            {
                return Name.CompareTo(e.Name);
            }
            throw new ArgumentException("o is not an Employee object.");
        }
    }

    public class Manager: Employee {
        public int Rank {get; set;}
    }
}