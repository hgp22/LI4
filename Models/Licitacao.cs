using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpShift.Models
{
    public class Licitacao {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        [ForeignKey("Utilizador")]
        public string UsernameUtilizador { get; set; }
        [ForeignKey("Veiculo")]
        public int IdVeiculo { get; set; }
        [ForeignKey("Leilao")]
        public int IdLeilao { get; set; }

        public Licitacao() { }
        public Licitacao(decimal valor, string username, int idLeilao)
        {
            Valor = valor;
            UsernameUtilizador = username;
            IdLeilao = idLeilao;
        }

        public Licitacao(int id, DateTime createdAt, decimal valor, string username, int idLeilao)
        {
            Valor = valor;
            UsernameUtilizador = username;
            IdLeilao = idLeilao;
            Id = id;
            Data = createdAt;
        }
    }
}
