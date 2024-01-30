using UpShift.Models;

namespace UpShift.Controllers
{
    public interface IModeloController
    {
        bool Create(Modelo modelo);
        bool Delete(int id);
        bool Update(Modelo modelo);
        Modelo GetById(int id);
        List<Modelo> GetAll();
    }
}
