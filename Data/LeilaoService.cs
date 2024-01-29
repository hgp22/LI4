using UpShift.Models;

namespace UpShift.Data
{
    public class LeilaoService
    {
        private List<Leilao> _leiloes;

        public LeilaoService()
        {
            _leiloes = new List<Leilao>()
            {
                new Leilao(1, "Leilao A", null, 2000, 100, new DateTime(2024, 01, 30, 23, 59, 59), false, null, "Amazing Car", "admin123", 1, -1),
                new Leilao(2, "Leilao B", null, 5020, 200, new DateTime(2024, 01, 30, 23, 59, 59), false, null, "Luxury Car", "admin123", 2, -1)
            };
        }

        public List<Leilao> GetAll()
        {
            return _leiloes.ToList();
        }

        public Leilao Get(int id)
        {
            return _leiloes.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Leilao leilao)
        {
            _leiloes.Add(leilao);
        }

        public void Delete(int id)
        {
            var leilaoToDelete = _leiloes.FirstOrDefault(v => v.Id == id);
            if (leilaoToDelete != null)
            {
                _leiloes.Remove(leilaoToDelete);
            }
        }

        public void Update(Leilao leilao)
        {
            var existingLeilao = Get(leilao.Id);
            if (existingLeilao == null)
            {
                return;
            }
            existingLeilao.Titulo = leilao.Titulo;
            existingLeilao.Fotografias = leilao.Fotografias;    
            existingLeilao.PrecoStart = leilao.PrecoStart;
            existingLeilao.BidMinima = leilao.BidMinima;
            existingLeilao.DataFinal = leilao.DataFinal;
            existingLeilao.LeilaoAcabou = leilao.LeilaoAcabou;
            existingLeilao.VideoLink = leilao.VideoLink;
            existingLeilao.Descricao = leilao.Descricao;
            existingLeilao.UsernameAdmin = leilao.UsernameAdmin;
            existingLeilao.IdVeiculo = leilao.IdVeiculo;
            existingLeilao.IdLicitacaoAtual = leilao.IdLicitacaoAtual;
        }
    }
}
