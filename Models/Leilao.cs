namespace UpShift.Models
{
    public class Leilao {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Fotografias { get; set; }
        public int PrecoStart { get; set; }
        public int BidMinima { get; set; }
        public DateTime DataFinal { get; set; }
        public bool LeilaoAcabou { get; set; }
        public string VideoLink { get; set; }
        public string Descricao { get; set; }
        public string UsernameAdmin { get; set; }
        public int IdVeiculo { get; set; }
        public int IdLicitacaoAtual { get; set; }

        public Leilao(int id, string titulo, string fotografias, int precoStart, int bidMinima, DateTime dataFinal, bool leilaoAcabou, string videoLink, string descricao, string usernameAdmin, int idVeiculo, int idLicitacaoAtual)
        {
            Id = id;
            Titulo = titulo;
            Fotografias = fotografias;
            PrecoStart = precoStart;
            BidMinima = bidMinima;
            DataFinal = dataFinal;
            LeilaoAcabou = leilaoAcabou;
            VideoLink = videoLink;
            Descricao = descricao;
            UsernameAdmin = usernameAdmin;
            IdVeiculo = idVeiculo;
            IdLicitacaoAtual = idLicitacaoAtual;
        }   
    }
}
