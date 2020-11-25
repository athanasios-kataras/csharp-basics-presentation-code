namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Strategy
{
    public class Server
    {
        public int Id {get; set;}
        public string Ip {get; set;}
        public string Name {get; set;}
        public decimal CpuUtilization {get; set;}
        public decimal MemoryUtilization {get; set;}

        public void Refresh() {
            // Do some refresh action
        }
    }
}