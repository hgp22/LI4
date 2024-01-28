namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            var u1 = new UserAccount("admin", "admin", "admin@gmail.com", "Administrator");
            var u2 = new UserAccount("user", "user", "user@gmail.com", "User");
            u1.DetalhesEntrega = 1;
            u1.MetodoPagamento = 1;
            _users = new List<UserAccount>
            {
                u1, u2
            };
        }

        public void AddUser( UserAccount user )
        {
            _users.Add( user );
        }
        public bool Delete(string username)
        {
            var user = GetByUserName(username);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }
        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }

        public List<UserAccount> GetAll()
        {
            return _users.ToList();
        }

        public UserAccount? GetByEmail(string email)
        {
            return _users.FirstOrDefault(x => x.Email == email);
        }

        public bool Update(UserAccount user)
        {
            var existingUser = _users.FirstOrDefault(x => x.UserName == user.UserName);

            if (existingUser != null)
            {
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;
                existingUser.DetalhesEntrega = user.DetalhesEntrega;
                existingUser.MetodoPagamento = user.MetodoPagamento;


                return true;
            }

            return false;
        }
    }
}
