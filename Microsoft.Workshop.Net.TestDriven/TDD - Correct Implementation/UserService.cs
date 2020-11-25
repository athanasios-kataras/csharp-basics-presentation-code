namespace Microsoft.Workshop.Net.TestDriven.TDD___Correct_Implementation
{
    public class UserService: IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Login(string username, string password) {
            User user = userRepository.GetByUsername(username);
            if(user.Password.Equals(password)) 
                return true;

            return false;
        }
    }
}