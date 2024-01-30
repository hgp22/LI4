using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpShift.Models
{
    public class Veiculo {
        [Key]
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string CorExterior { get; set; }
        public int NumPortas { get; set; }
        public int Cilindrada { get; set; }
        public int Potencia { get; set; }
        public int Lugares { get; set; }
        public int TipoMotor { get; set; }
        [ForeignKey("Marca")]
        public int IdMarca { get; set; }
        [ForeignKey("Modelo")]
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
            TipoMotor = combustivel;
            IdMarca = idMarca;
            IdModelo = idModelo;
        }

        public Veiculo() { }
    }
}
