using System;
using System.Collections.Generic;
using System.Linq;

namespace UpShift.Authentication
{
    public class UserAccountService
    {
        private static List<Utilizador> _users;

        public UserAccountService()
        {
            _users = new List<Utilizador>()
            {
                new Utilizador("admin", "admin", "admin@example.com", new DateTime(1990, 1, 1), "123456789", 1, 1, "Administrator"),
                new Utilizador("utilizador1", "utilizador1", "utilizador1@example.com", new DateTime(1995, 5, 15), "987654321", 2, 2, "User"),
                new Utilizador("utilizador2", "utilizador2", "utilizador2@example.com", new DateTime(1988, 10, 8), "456789012", 3, 3, "User")
            };
        }

        public Utilizador? GetByUsername(string username)
        {
            return _users.FirstOrDefault(x => x.Username == username);
        }
    }
}
