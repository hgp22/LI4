using UpShift.Models;

namespace UpShift.Controllers
{
    public interface IVeiculoController
    {
        bool Update(Veiculo Veiculo);
        bool Delete(int id);
        bool Create(Veiculo veiculo);
        Veiculo GetById(int id);
        List<Veiculo> GetAll();
    }
}
