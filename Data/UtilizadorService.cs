using UpShift.Models;

namespace UpShift.Data
{
    public class UtilizadorService
    {
        private readonly DataBaseContext _ctx;

        public UtilizadorService(DataBaseContext ctx)
        {
            _ctx = ctx;
        }
        public List<Utilizador> GetAll()
        {
            return _ctx.Utilizadores.ToList();
        }

        public Utilizador? GetByUserName(string userName)
        {
            return _ctx.Utilizadores.FirstOrDefault(x => x.Username == userName);
        }

        public Utilizador? GetByEmail(string email)
        {
            return _ctx.Utilizadores.FirstOrDefault(x => x.Email == email);
        }

        public void Add(Utilizador utilizador)
        {
            _ctx.Utilizadores.Add(utilizador);
            _ctx.SaveChanges();
        }

        public void Delete(string username)
        {
            var utilizadorToDelete = _ctx.Utilizadores.FirstOrDefault(v => v.Username == username);
            if (utilizadorToDelete != null)
            {
                _ctx.Utilizadores.Remove(utilizadorToDelete);
                _ctx.SaveChanges();
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
            existingUtilizador.IsAdmin = utilizador.IsAdmin;
            existingUtilizador.MetodoPagamento = utilizador.MetodoPagamento;
            existingUtilizador.DetalhesEntrega = utilizador.DetalhesEntrega;

            _ctx.SaveChanges();

            return true;
        }
    }
}
