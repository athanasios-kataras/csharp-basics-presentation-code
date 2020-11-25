namespace Microsoft.Workshop.Net.OOPFundamentals
{
    internal class IndexingProcessor : IProcessor
    {
        private Repository repository;

        public IndexingProcessor(Repository repository)
        {
            this.repository = repository;
        }

        public void Process()
        {
            throw new System.NotImplementedException();
        }
    }
}