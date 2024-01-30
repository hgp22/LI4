using System.ComponentModel.DataAnnotations;

namespace UpShift.Models
{
    public class Marca {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Marca(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
