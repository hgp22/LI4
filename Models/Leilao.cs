using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpShift.Models
{
    public class Leilao {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Fotografias { get; set; }
        public int ValorInicial { get; set; }
        public int AumentoMinimo { get; set; }
        public DateTime DataFinal { get; set; }
        public bool LeilaoAcabou { get; set; }
        public string VideoLink { get; set; }
        public string Descricao { get; set; }
        [ForeignKey("Utilizador")]
        public string UsernameAdmin { get; set; }
        [ForeignKey("Veiculo")]
        public int IdVeiculo { get; set; }
        [ForeignKey("Licitacao")]
        public int IdLicitacaoAtual { get; set; }

        public Leilao(string titulo, int fotografias, int precoStart, int bidMinima, DateTime dataFinal, bool leilaoAcabou, string videoLink, string descricao, string usernameAdmin, int idVeiculo, int idLicitacaoAtual)
        {
            Titulo = titulo;
            Fotografias = fotografias;
            ValorInicial = precoStart;
            AumentoMinimo = bidMinima;
            DataFinal = dataFinal;
            LeilaoAcabou = leilaoAcabou;
            VideoLink = videoLink;
            Descricao = descricao;
            UsernameAdmin = usernameAdmin;
            IdVeiculo = idVeiculo;
            IdLicitacaoAtual = idLicitacaoAtual;
        }


        public Leilao(int id, string titulo, int fotografias, int precoStart, int bidMinima, DateTime dataFinal, bool leilaoAcabou, string videoLink, string descricao, string usernameAdmin, int idVeiculo, int idLicitacaoAtual)
        {
            Id = id;
            Titulo = titulo;
            Fotografias = fotografias;
            ValorInicial = precoStart;
            AumentoMinimo = bidMinima;
            DataFinal = dataFinal;
            LeilaoAcabou = leilaoAcabou;
            VideoLink = videoLink;
            Descricao = descricao;
            UsernameAdmin = usernameAdmin;
            IdVeiculo = idVeiculo;
            IdLicitacaoAtual = idLicitacaoAtual;
        }   

        public Leilao() { }
    }
}
