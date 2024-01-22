namespace BlazorServerAuthenticationAndAuthorization.Models
{
    public class VeiculoLeilao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        public int Lugares { get; set; }
        public int Kilometragem { get; set; }
        public int Cilindrada { get; set; }
        public int Potencia { get; set; }
        public int Portas { get; set; }

        public decimal PrecoStart { get; set; }
        public decimal BidMinima { get; set; }
        public decimal ValorAtual { get; set; }
        public DateOnly FinalLeilao { get; set; }
        public bool LeilaoAcabou { get; set; }
        public List<string> Imagens { get; set; }
        public List<string> Videos { get; set; }



        public VeiculoLeilao(int  id, string titulo, int ano, string marca, string modelo, string descricao, string combustivel, string cor, int lugares,
                             int kilometragem, int cilindrada, int potencia, int portas, decimal precoStart, decimal bidMinima, DateOnly finalLeilao,
                             bool leilaoAcabou, List<string> imagens, List<string> videos)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Marca = marca;
            Modelo = modelo;
            Descricao = descricao;
            Combustivel = combustivel;
            Cor = cor;
            Lugares = lugares;
            Kilometragem = kilometragem;
            Cilindrada = cilindrada;
            Potencia = potencia;
            Portas = portas;
            PrecoStart = precoStart;
            BidMinima = bidMinima;
            FinalLeilao = finalLeilao;
            Imagens = imagens;
            Videos = videos;
            ValorAtual = PrecoStart;
        }

        public void updateValorAtual(Licitacao licitacao)
        {
            ValorAtual = licitacao.Valor;
        }

        public VeiculoLeilao() { }
    }

}
