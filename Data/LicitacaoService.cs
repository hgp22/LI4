using UpShift.Models;
using UpShift.Pages;

namespace UpShift.Data
{
    public class LicitacaoService
    {
        private List<Licitacao> licitacoes;
        private int nextId = 1;

        public LicitacaoService()
        {
            licitacoes = new List<Licitacao>
            {
            };
        }

        public Licitacao GetByID(int id)
        {
            return licitacoes.FirstOrDefault(l => l.Id == id);
        }

        public List<Licitacao> GetAllDeUser(string username)
        {
            return licitacoes.Where(l => l.UsernameUtilizador == username).ToList();
        }

        public List<Licitacao> GetAllDeLeilao(int leilaoId)
        {
            return licitacoes.Where(l => l.IdLeilao == leilaoId).ToList();
        }

        public void Delete(int id)
        {
            var licitacao = GetByID(id);
            if (licitacao != null)
            {
                licitacoes.Remove(licitacao);
            }
        }

        public void Add(Licitacao novaLicitacao)
        {
            novaLicitacao.Id = nextId++;
            novaLicitacao.Data = DateTime.Now;
            licitacoes.Add(novaLicitacao);
        }
    }
}

