namespace UpShift.Models
{
    public class Modelo {
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
