namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount("admin", "admin", "Administrator"),
                new UserAccount("user", "user", "User" )
            };
        }

        public void AddUser( UserAccount user )
        {
            _users.Add( user );
        }
        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
