using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class VeiculoController : IVeiculoController
    {
        private VeiculoService _veiculoService;
        public VeiculoController()
        {
            _veiculoService = new VeiculoService();
        }
        public bool Create(Veiculo veiculo)
        {
            try
            {
                _veiculoService.Add(veiculo);
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
                _veiculoService.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Veiculo> GetAll()
        {
            return _veiculoService.GetAll();
        }

        public Veiculo GetById(int id)
        {
            return _veiculoService.Get(id);
        }


        public bool Update(Veiculo veiculo)
        {
            return _veiculoService.Update(veiculo);
        }
    }
}
