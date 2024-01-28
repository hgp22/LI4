namespace UpShift.Models
{
    public class Licitacao
    {
        public int Id { get; set; }
        public int IdVeiculoLeilao { get; set; }
        public string UsernameCliente { get; set; }
        public decimal ValorLicitacao { get; set; }
        public DateTime Timestamp { get; set; }

        public Licitacao(int id, int idVeiculoLeilao, string usernameCliente, decimal valorLicitacao, DateTime timestamp)
        {
            Id = id;
            IdVeiculoLeilao = idVeiculoLeilao;
            UsernameCliente = usernameCliente;
            ValorLicitacao = valorLicitacao;
            Timestamp = timestamp;
        }
    }
}

