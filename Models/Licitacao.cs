namespace UpShift.Models
{
    public class Licitacao {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string UsernameUtilizador { get; set; }
        public int IdVeiculo { get; set; }
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
