using UpShift.Models; 

namespace UpShift.Controllers
{
    public interface IMarcaController
    {
        bool Create(Marca marca);
        bool Delete(int id);
        bool Update(Marca marca);
        Marca GetById(int id);
        List<Marca> GetAll();
    }
}
