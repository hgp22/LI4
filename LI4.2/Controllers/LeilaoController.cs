using Microsoft.AspNetCore.Mvc;
using BlazorServerAuthenticationAndAuthorization.Data;
using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Controllers
{

    public class LeilaoController : ILeilaoController
    {
        private VeiculoLeilaoService _veiculoLeilaoService;
        //private readonly DataBaseContext _ctx;
        public LeilaoController(VeiculoLeilaoService veiculoLeilaoService)
        {
            _veiculoLeilaoService = veiculoLeilaoService;
            //_ctx = ctx
        }
        bool ILeilaoController.Create(VeiculoLeilao veiculoLeilao)
        {
            try
            {
                _veiculoLeilaoService.Add(veiculoLeilao); //mudar para a databse conection quando houver
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        bool ILeilaoController.Delete(VeiculoLeilao veiculoLeilao)
        {
            try
            {
                _veiculoLeilaoService.Delete(veiculoLeilao.Id); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        List<VeiculoLeilao> ILeilaoController.GetAll()
        {
            try
            {
                return _veiculoLeilaoService.GetAll(); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        VeiculoLeilao ILeilaoController.GetByID(int id)
        {
            try
            {
                return _veiculoLeilaoService.Get(id); //mudar para a databse conection quando houver
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(VeiculoLeilao veiculoLeilao)
        {
            try
            {
                _veiculoLeilaoService.Update(veiculoLeilao);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

