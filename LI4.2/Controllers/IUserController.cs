using BlazorServerAuthenticationAndAuthorization.Authentication;

namespace BlazorServerAuthenticationAndAuthorization.Controllers
{
    public interface IUserController
    {
        bool Update(UserAccount userAccount);
        bool Delete(string username);
        bool Create(UserAccount userAccount);
        UserAccount GetByUsername(string username);
        UserAccount GetByEmail(string email);
        List<UserAccount> GetAll();
        bool HasMetodoPagamento(string username);
        bool HasDetalhesEntrega(string username);
    }
}
