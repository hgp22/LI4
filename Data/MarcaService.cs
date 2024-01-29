using UpShift.Models;

namespace UpShift.Data
{
    public class MarcaService
    {
        private List<Marca> _marcas;

        public MarcaService()
        {
            _marcas = new List<Marca>
            {
                new Marca(1, "Audi"),
                new Marca(2, "BMW"),
                new Marca(3, "Citroen"),
                new Marca(4, "Fiat"),
                new Marca(5, "Ford"),
                new Marca(6, "Mercedes"),
                new Marca(7, "Nissan"),
                new Marca(8, "Opel"),
                new Marca(9, "Peugeot"),
                new Marca(10, "Renault")
            };
        }

        public List<Marca> GetAll()
        {
            return _marcas.ToList();
        }

        public Marca Get(int id)
        {
            return _marcas.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Marca marca)
        {
            _marcas.Add(marca);
        }

        public void Delete(int id)
        {
            var marcaToDelete = _marcas.FirstOrDefault(v => v.Id == id);
            if (marcaToDelete != null)
            {
                _marcas.Remove(marcaToDelete);
            }
        }

        public void Update(Marca marca)
        {
            var existingMarca = Get(marca.Id);
            if (existingMarca == null)
            {
                return;
            }
            existingMarca.Nome = marca.Nome;
        }
    }
}
