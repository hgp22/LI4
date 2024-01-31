using UpShift.Models;
using UpShift.Pages;

namespace UpShift.Data
{
    public class LicitacaoService
    {
        private readonly DataBaseContext _ctx;

        public LicitacaoService(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public Licitacao GetByID(int id)
        {
            return _ctx.Licitacoes.FirstOrDefault(l => l.Id == id);
        }

        public List<Licitacao> GetAllDeUser(string username)
        {
            return _ctx.Licitacoes.Where(l => l.UsernameUtilizador == username).ToList();
        }

        public List<Licitacao> GetAllDeLeilao(int leilaoId)
        {
            return _ctx.Licitacoes.Where(l => l.IdLeilao == leilaoId).ToList();
        }

        public void Delete(int id)
        {
            var licitacao = GetByID(id);
            if (licitacao != null)
            {
                _ctx.Licitacoes.Remove(licitacao);
                _ctx.SaveChanges();
            }
        }

        public void Add(Licitacao novaLicitacao)
        {
            novaLicitacao.Data = DateTime.Now;
            _ctx.Licitacoes.Add(novaLicitacao);
            _ctx.SaveChanges();
        }
    }
}

