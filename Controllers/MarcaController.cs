using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class MarcaController : IMarcaController
    {
        private MarcaService _marcaService;

        public MarcaController(MarcaService marcaService)
        {
            _marcaService = marcaService;
        }
        public bool Create(Marca marca)
        {
            try
            {
                _marcaService.Add(marca); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _marcaService.Delete(id); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Marca> GetAll()
        {
            try
            {
                return _marcaService.GetAll(); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Marca GetById(int id)
        {
            try
            {
                return _marcaService.Get(id); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Marca marca)
        {
            try
            {
                _marcaService.Update(marca);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
