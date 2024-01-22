using BlazorServerAuthenticationAndAuthorization.Data;
using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Controllers
{
    public class LicitacaoController : ILicitacaoController
    {
        private LicitacaoService _licitacaoService;
        //private readonly DataBaseContext _ctx;

        public LicitacaoController(LicitacaoService licitacaoService)
        {
            _licitacaoService = licitacaoService;
            //_ctx = ctx
        }

        bool ILicitacaoController.Create(Licitacao licitacao)
        {
            try
            {
                _licitacaoService.Add(licitacao); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool ILicitacaoController.Delete(Licitacao licitacao)
        {
            try
            {
                _licitacaoService.Delete(licitacao.Id); //mudar para a databse conection quando houver
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        List<Licitacao> ILicitacaoController.GetAllDeLeilao(int leilaoID)
        {
            return _licitacaoService.GetAllDeLeilao(leilaoID);
        }

        List<Licitacao> ILicitacaoController.GetAllDeUser(int userID)
        {
            return _licitacaoService.GetAllDeUser(userID);
        }

        Licitacao ILicitacaoController.GetByID(int id)
        {
            return _licitacaoService.GetByID(id);
        }

        bool ILicitacaoController.MarkHasWinner(Licitacao licitacao)
        {
            try
            {
                _licitacaoService.MarkAsWinner(licitacao);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
