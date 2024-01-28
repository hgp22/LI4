using BlazorServerAuthenticationAndAuthorization.Authentication;
namespace BlazorServerAuthenticationAndAuthorization.Controllers
{
    public class UserController : IUserController
    {
        private UserAccountService _userAccountService;
        //private readonly DataBaseContext _ctx;
        public UserController(UserAccountService userAccountService) 
        {
            //_ctx = ctx
            _userAccountService = userAccountService;
        }
        bool IUserController.Create(UserAccount userAccount)
        {
            try
            {
                _userAccountService.AddUser(userAccount);
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
                _userAccountService.Delete(username);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        List<UserAccount> IUserController.GetAll()
        {
            return _userAccountService.GetAll();
        }

        UserAccount IUserController.GetByEmail(string email)
        {
            return _userAccountService.GetByEmail(email);
        }

        UserAccount IUserController.GetByUsername(string username)
        {
            return _userAccountService.GetByUserName(username);
        }

        bool IUserController.Update(UserAccount userAccount)
        {
            return _userAccountService.Update(userAccount);
        }

        public bool HasMetodoPagamento(string username)
        {
            var user = _userAccountService.GetByUserName(username);
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
            var user = _userAccountService.GetByUserName(username);
            if (user == null)
            {
                return false;
            }
            return user.HasDetalhesEntrega();
        }
    }
}
