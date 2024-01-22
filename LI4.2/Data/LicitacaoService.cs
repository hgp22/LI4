using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Data
{
    public class LicitacaoService
    {
        private List<Licitacao> licitacoes = new List<Licitacao>();
        private int nextId = 1;

        public Licitacao GetByID(int id)
        {
            return licitacoes.FirstOrDefault(l => l.Id == id);
        }

        public List<Licitacao> GetAllDeUser(int userId)
        {
            return licitacoes.Where(l => l.IdUtilizador == userId).ToList();
        }

        public List<Licitacao> GetAllDeLeilao(int leilaoId)
        {
            return licitacoes.Where(l => l.IdLeilao == leilaoId).ToList();
        }

        public void MarkAsWinner(Licitacao licitacao)
        {
            if (licitacao != null)
            {
                licitacao.Winner = true;
            }
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
            novaLicitacao.CreatedAt = DateTime.Now;
            licitacoes.Add(novaLicitacao);
        }
    }
}

