using Microsoft.AspNetCore.Mvc;
using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{

    public class LeilaoController : ILeilaoController
    {
        private LeilaoService _leilaoService;
        public LeilaoController(LeilaoService veiculoLeilaoService, DataBaseContext ctx)
        {
            _leilaoService = veiculoLeilaoService;
        }
        bool ILeilaoController.Create(Leilao leilao)
        {
            try
            {
                _leilaoService.Add(leilao); //mudar para a databse conection quando houver
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        bool ILeilaoController.Delete(Leilao leilao)
        {
            try
            {
                _leilaoService.Delete(leilao.Id); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        List<Leilao> ILeilaoController.GetAll()
        {
            try
            {
                return _leilaoService.GetAll(); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        Leilao ILeilaoController.GetByID(int id)
        {
            try
            {
                return _leilaoService.Get(id); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Leilao leilao)
        {
            try
            {
                _leilaoService.Update(leilao);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Veiculo getVeiculo(int id)
        {
               return _leilaoService.GetVeiculo(id);
        }
    }
}

