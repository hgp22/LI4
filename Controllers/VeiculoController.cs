using Microsoft.AspNetCore.Mvc;
using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class VeiculoController : IVeiculoController
    {
        private VeiculoService _veiculoService;
        //private readonly DataBaseContext _ctx;
        public VeiculoController(VeiculoService veiculoService)
        {
            //_ctx = ctx
            _veiculoService = veiculoService;
        }
        bool IVeiculoController.Create(Veiculo veiculo)
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

        bool IVeiculoController.Delete(int id)
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

        List<Veiculo> IVeiculoController.GetAll()
        {
            return _veiculoService.GetAll();
        }

        Veiculo IVeiculoController.GetById(int id)
        {
            return _veiculoService.Get(id);
        }

        bool IVeiculoController.Update(Veiculo veiculo)
        {
            return _veiculoService.Update(veiculo);
        }
    }
}
