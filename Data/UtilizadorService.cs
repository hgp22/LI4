using UpShift.Models;

namespace UpShift.Data
{
    public class UtilizadorService
    {
        private List<Utilizador> _utilizadores;

        public UtilizadorService()
        {
            _utilizadores = new List<Utilizador>()
            {
                new Utilizador("admin", "admin@admin", "admin", 1, "admin", new DateTime(2020, 2, 20), "Administrator"),
                new Utilizador("joao123", "joao123@gmail.com", "password123", 912345678, "João Papão", new DateTime(1999, 12, 31), "User"),
                new Utilizador("maria123", "maria123@gmail.com", "password123", 912345678, "Maria Papoa", new DateTime(2001, 09, 12), "User"),
                new Utilizador("carlos123", "carlos123@gmail.com", "password123", 912345678, "Carlos Papão", new DateTime(1998, 01, 01), "User"),
                new Utilizador("ana123", "ana123@gmail.com", "password123", 912345678, "Ana Papoa", new DateTime(1997, 02, 02), "User"),
                new Utilizador("pedro123", "pedro123@gmail.com", "password123", 912345678, "Pedro Papão", new DateTime(1996, 03, 03), "User")
            };

        }
        public List<Utilizador> GetAll()
        {
            return _utilizadores.ToList();
        }

        public Utilizador? GetByUserName(string userName)
        {
            return _utilizadores.FirstOrDefault(x => x.Username == userName);
        }

        public Utilizador? GetByEmail(string email)
        {
            return _utilizadores.FirstOrDefault(x => x.Email == email);
        }

        public void Add(Utilizador utilizador)
        {
            _utilizadores.Add(utilizador);
        }

        public void Delete(string username)
        {
            var utilizadorToDelete = _utilizadores.FirstOrDefault(v => v.Username == username);
            if (utilizadorToDelete != null)
            {
                _utilizadores.Remove(utilizadorToDelete);
            }
        }

        public bool Update(Utilizador utilizador)
        {
            var existingUtilizador = GetByUserName(utilizador.Username);
            if (existingUtilizador == null)
            {
                return false;
            }

            existingUtilizador.Email = utilizador.Email;
            existingUtilizador.Password = utilizador.Password;
            existingUtilizador.Nif = utilizador.Nif;
            existingUtilizador.Nome = utilizador.Nome;
            existingUtilizador.DataNascimento = utilizador.DataNascimento;
            existingUtilizador.Role = utilizador.Role;
            existingUtilizador.MetodoPagamento = utilizador.MetodoPagamento;
            existingUtilizador.DetalhesEntrega = utilizador.DetalhesEntrega;

            return true;
        }
    }
}
