using UpShift.Data;
using UpShift.Models;
namespace UpShift.Controllers
{
    public class UserController : IUserController
    {
        private UtilizadorService _utilizadorService;
        //private readonly DataBaseContext _ctx;
        public UserController(UtilizadorService utilizadorService) 
        {
            //_ctx = ctx
            _utilizadorService = utilizadorService;
        }
        bool IUserController.Create(Utilizador user)
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

        bool IUserController.Delete(string username)
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

        List<Utilizador> IUserController.GetAll()
        {
            return _utilizadorService.GetAll();
        }

        Utilizador IUserController.GetByEmail(string email)
        {
            return _utilizadorService.GetByEmail(email);
        }

        Utilizador IUserController.GetByUsername(string username)
        {
            return _utilizadorService.GetByUserName(username);
        }

        bool IUserController.Update(Utilizador userAccount)
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
