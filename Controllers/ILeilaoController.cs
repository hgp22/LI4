using UpShift.Models;

namespace UpShift.Controllers
{
    public interface ILeilaoController
    {
        bool Create(Leilao leilao);
        bool Delete(int id);
        bool Update(Leilao leilao);
        Leilao GetByID(int id);
        List<Leilao> GetAll();
        Veiculo GetVeiculo(int id);
    }
}
