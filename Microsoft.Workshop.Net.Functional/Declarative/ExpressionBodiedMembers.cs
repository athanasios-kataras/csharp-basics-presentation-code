namespace Microsoft.Workshop.Net.Functional.Declarative
{
    using System;
    public class EBMPerson
    {
        private string id;
        private string address;
        private string fname;
        private string lname;
        private string[] types = { "Baseball", "Basketball", "Football",
                              "Hockey", "Soccer", "Tennis",
                              "Volleyball" };
        // Indexer EMB
        public string this[int i]
        {
            get => types[i];
            set => types[i] = value;
        }
        // Constructor EMB
        public EBMPerson(string firstName, string lastName) => (fname, lname) = (firstName, lastName);
        // Method EMB
        public override string ToString() => $"{fname} {lname}".Trim();
        // Property EMB
        public string Address
        {
            get => address;
            set => address = value;
        }
        // Read-only property EMB
        public string Id => this.id;
        // Finalizer EMB
         ~EBMPerson() => Console.WriteLine($"The {ToString()} destructor is executing.");

    }
    public class ExpressionBodiedMembers
    {

    }
}