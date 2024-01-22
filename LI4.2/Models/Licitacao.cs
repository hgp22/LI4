namespace BlazorServerAuthenticationAndAuthorization.Models
{
    public class Licitacao
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Valor{ get; set; }
        public int IdUtilizador { get; set; }
        public int IdLeilao { get; set; }
        public Boolean Winner { get; set; }

        public Licitacao() { }
        public Licitacao(decimal valor, int idUtilizador, int idLeilao)
        {
            Valor = valor;
            IdUtilizador = idUtilizador;
            IdLeilao = idLeilao;
            Winner = false;
        }
    }
}
