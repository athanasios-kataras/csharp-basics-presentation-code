namespace Microsoft.Workshop.Net.TestDriven.TDD___Wrong_Implementation
{
    public class UserService
    {
        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            if (username.Equals("John") && password.Equals("Snow"))
                return true;

            return false;
        }
    }
}