using UpShift.Models;

namespace UpShift.Controllers
{
    public interface ILicitacaoController
    {
        bool Create(Licitacao licitacao);
        bool Delete(Licitacao licitacao);
        Licitacao GetByID(int id);
        List<Licitacao> GetAllDeUser(string username);
        List<Licitacao> GetAllDeLeilao(int leilaoID);
        
    }
}
