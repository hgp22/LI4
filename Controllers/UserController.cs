using UpShift.Data;
using UpShift.Models;
namespace UpShift.Controllers
{
    public class UserController : IUserController
    {
        private UtilizadorService _utilizadorService;
        public UserController() 
        {
            _utilizadorService = new UtilizadorService();
        }
        public bool Create(Utilizador user)
        {
            try
            {
                _utilizadorService.Add(user);
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }

        public bool Delete(string username)
        {
            try
            {
                _utilizadorService.Delete(username);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Utilizador> GetAll()
        {
            return _utilizadorService.GetAll();
        }

        public Utilizador GetByEmail(string email)
        {
            return _utilizadorService.GetByEmail(email);
        }

        public Utilizador GetByUsername(string username)
        {
            return _utilizadorService.GetByUserName(username);
        }
        public bool Update(Utilizador userAccount)
        {
            return _utilizadorService.Update(userAccount);
        }

        public bool HasMetodoPagamento(string username)
        {
            var user = _utilizadorService.GetByUserName(username);
            if (user == null)
            {
                return false;
            }
            else
            {
                return user.HasMetodoPagamento();

            }
        }

        public bool HasDetalhesEntrega(string username)
        {
            var user = _utilizadorService.GetByUserName(username);
            if (user == null)
            {
                return false;
            }
            return user.HasDetalhesEntrega();
        }

    }
}
