using UpShift.Models;

namespace UpShift.Data
{
    public class ModeloService
    {
        private List<Modelo> _modelos;

        public ModeloService ()
        {
            _modelos = new List<Modelo>()
            {
                new Modelo(1, "A1", 1),
                new Modelo(2, "A3", 1),
                new Modelo(3, "Serie 1", 2),
                new Modelo(4, "Serie 3", 2),
                new Modelo(5, "C3", 3),
                new Modelo(6, "C4", 3),
                new Modelo(7, "500", 4),
                new Modelo(8, "Punto", 4),
                new Modelo(9, "Fiesta", 5),
                new Modelo(10, "Focus", 5),
                new Modelo(11, "Classe A", 6),
                new Modelo(12, "Classe C", 6),
                new Modelo(13, "Micra", 7),
                new Modelo(14, "Qashqai", 7),
                new Modelo(15, "Corsa", 8),
                new Modelo(16, "Astra", 8),
                new Modelo(17, "208", 9),
                new Modelo(18, "308", 9),
                new Modelo(19, "Clio", 10),
                new Modelo(20, "Megane", 10)
            };
        }
        public List<Modelo> GetAll()
        {
            return _modelos.ToList();
        }

        public Modelo Get(int id)
        {
            return _modelos.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Modelo modelo)
        {
            _modelos.Add(modelo);
        }

        public void Delete(int id)
        {
            var modeloToDelete = _modelos.FirstOrDefault(v => v.Id == id);
            if (modeloToDelete != null)
            {
                _modelos.Remove(modeloToDelete);
            }
        }

        public void Update(Modelo modelo)
        {
            var existingModelo = Get(modelo.Id);
            if (existingModelo == null)
            {
                return;
            }
            existingModelo.Nome = modelo.Nome;
        }
    }
}
