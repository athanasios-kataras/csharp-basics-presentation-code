namespace Microsoft.Workshop.Net.OOPFundamentals
{
    internal class CompositeProcessor : IProcessor
    {
        private IProcessor processor;
        private DeleteProcessor deleteProcessor;

        public CompositeProcessor(IProcessor processor, DeleteProcessor deleteProcessor)
        {
            this.processor = processor;
            this.deleteProcessor = deleteProcessor;
        }

        public void Process()
        {
            throw new System.NotImplementedException();
        }
    }
}