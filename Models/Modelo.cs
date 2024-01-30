using System.ComponentModel.DataAnnotations;

namespace UpShift.Models
{
    public class Modelo {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdMarca { get; set; }

        public Modelo(int id, string nome, int idMarca)
        {
            Id = id;
            Nome = nome;
            IdMarca = idMarca;
        }
    }
}
