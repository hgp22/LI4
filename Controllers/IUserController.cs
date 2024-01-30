using UpShift.Models;

namespace UpShift.Controllers
{
    public interface IUserController
    {
        bool Create(Utilizador user);
        bool Delete(string username);
        bool Update(Utilizador userAccount);
        Utilizador GetByEmail(string email);
        Utilizador GetByUsername(string username);
        List<Utilizador> GetAll();
        bool HasMetodoPagamento(string username);
    }
}
