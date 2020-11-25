namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Balance {get; set;}

        public void PostChanges() {
            // Some database post changes
        }
        
    }
}