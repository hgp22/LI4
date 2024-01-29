namespace UpShift.Models
{
    public class Veiculo {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string CorExterior { get; set; }
        public int NumPortas { get; set; }
        public int Cilindrada { get; set; }
        public int Potencia { get; set; }
        public int Lugares { get; set; }
        public int Combustivel { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }

        public Veiculo(int id, int ano, int quilometragem, string corExterior, int numPortas, int cilindrada, int potencia, int lugares, int combustivel, int idMarca, int idModelo)
        {
            Id = id;
            Ano = ano;
            Quilometragem = quilometragem;
            CorExterior = corExterior;
            NumPortas = numPortas;
            Cilindrada = cilindrada;
            Potencia = potencia;
            Lugares = lugares;
            Combustivel = combustivel;
            IdMarca = idMarca;
            IdModelo = idModelo;
        }
    }
}
