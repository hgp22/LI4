using Hangfire;
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



        public bool Create(Leilao leilao)
        {
            try
            {
                _leilaoService.Add(leilao); 
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _leilaoService.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Leilao> GetAll()
        {
            try
            {
                return _leilaoService.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Leilao GetByID(int id)
        {
            try
            {
                return _leilaoService.Get(id); 
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

        public Veiculo GetVeiculo(int id)
        {
               return _leilaoService.GetVeiculo(id);
        }

    }
}

