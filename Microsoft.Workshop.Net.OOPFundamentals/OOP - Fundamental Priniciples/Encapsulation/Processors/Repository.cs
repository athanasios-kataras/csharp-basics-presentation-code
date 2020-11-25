namespace Microsoft.Workshop.Net.OOPFundamentals
{
    internal class Repository
    {
        private object connectionString;

        public Repository(object connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}