namespace Microsoft.Workshop.Net.TestDriven.TDD___Correct_Implementation
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
    }
}