namespace Microsoft.Workshop.Net.OOPFundamentals.Lab.UnitTests
{
    class FakeRepository : IRepository
    {
        public int SaveSpeaker(Speaker speaker)
        {
            // Simulate saving a speaker and returning the ID since this is a simiple fake repository.
            return 1;
        }
    }
}