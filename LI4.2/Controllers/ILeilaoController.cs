using BlazorServerAuthenticationAndAuthorization.Authentication;
using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Controllers
{
    public interface ILeilaoController
    {
        bool Create(VeiculoLeilao veiculoLeilao);
        bool Delete(VeiculoLeilao veiculoLeilao);
        bool Update(VeiculoLeilao veiculoLeilao);
        VeiculoLeilao GetByID(int id);
        List<VeiculoLeilao> GetAll();
    }
}
