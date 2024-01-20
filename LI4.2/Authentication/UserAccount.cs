namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserAccount(string username, string password, string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
    }
}
