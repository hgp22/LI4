using UpShift.Models;

namespace UpShift.Authentication
{
    public class UserAccountService
    {
        private List<Utilizador> _users;

        public UserAccountService()
        {
            var u1 = new Utilizador("admin", "admin", "admin@gmail.com", "Administrator");
            var u2 = new Utilizador("user", "user", "user@gmail.com", "User");
            u1.DetalhesEntrega = 1;
            u1.MetodoPagamento = 1;
            _users = new List<Utilizador>
            {
                u1, u2
            };
        }

        public void AddUser( Utilizador user )
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
        public Utilizador? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.Username == userName);
        }

        public List<Utilizador> GetAll()
        {
            return _users.ToList();
        }

        public Utilizador? GetByEmail(string email)
        {
            return _users.FirstOrDefault(x => x.Email == email);
        }

        public bool Update(Utilizador user)
        {
            var existingUser = _users.FirstOrDefault(x => x.Username == user.Username);

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
