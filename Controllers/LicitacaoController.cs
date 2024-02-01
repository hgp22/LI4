using UpShift.Data;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class LicitacaoController : ILicitacaoController
    {
        private LicitacaoService _licitacaoService;

        public LicitacaoController(LicitacaoService licitacaoService)
        {
            _licitacaoService = licitacaoService;
        }

        bool ILicitacaoController.Create(Licitacao licitacao)
        {
            try
            {
                _licitacaoService.Add(licitacao); 
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
                _licitacaoService.Delete(licitacao.Id); 
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

        List<Licitacao> ILicitacaoController.GetAllDeUser(string username)
        {
            return _licitacaoService.GetAllDeUser(username);
        }

        Licitacao ILicitacaoController.GetByID(int id)
        {
            return _licitacaoService.GetByID(id);
        }
    }
}
