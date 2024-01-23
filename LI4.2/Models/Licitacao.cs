namespace BlazorServerAuthenticationAndAuthorization.Models
{
    public class Licitacao
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Valor{ get; set; }
        public string Username { get; set; }
        public int IdLeilao { get; set; }
        public Boolean Winner { get; set; }

        

        public Licitacao() { }
        public Licitacao(decimal valor, string username, int idLeilao)
        {
            Valor = valor;
            Username = username;
            IdLeilao = idLeilao;
            Winner = false;
        }

        public Licitacao(int id, DateTime createdAt, decimal valor, string username, int idLeilao)
        {
            Valor = valor;
            Username = username;
            IdLeilao = idLeilao;
            Winner = false;
            Id = id;
            CreatedAt = createdAt;
        }
    }
}
