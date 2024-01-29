using UpShift.Models;

namespace UpShift.Controllers
{
    public interface ILeilaoController
    {
        bool Create(Leilao leilao);
        bool Delete(Leilao leilao);
        bool Update(Leilao leilao);
        Leilao GetByID(int id);
        List<Leilao> GetAll();
    }
}
