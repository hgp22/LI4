using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class ModeloController : IModeloController
    {
        private ModeloService _modeloService;

        public ModeloController(ModeloService modeloService)
        {
            _modeloService = modeloService;
        }
        public bool Create(Modelo modelo)
        {
            try
            {
                _modeloService.Add(modelo); 
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
                _modeloService.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Modelo> GetAll()
        {
            try
            {
                return _modeloService.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Modelo GetById(int id)
        {
            try
            {
                return _modeloService.Get(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Modelo modelo)
        {
            try
            {
                _modeloService.Update(modelo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
