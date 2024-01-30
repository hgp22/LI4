using UpShift.Models;

namespace UpShift.Controllers
{
    public interface ILeilaoController
    {
        bool Create(int id);
        bool Delete(Leilao leilao);
        bool Update(Leilao leilao);
        Leilao GetByID(int id);
        List<Leilao> GetAll();
        Veiculo GetVeiculo(int id);
    }
}
