using UpShift.Models;

namespace UpShift.Data
{
    public class MarcaService
    {
        private readonly DataBaseContext _ctx;

        public MarcaService(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public List<Marca> GetAll()
        {
            return _ctx.Marcas.ToList();
        }

        public Marca Get(int id)
        {
            return _ctx.Marcas.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Marca marca)
        {
            _ctx.Marcas.Add(marca);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var marcaToDelete = _ctx.Marcas.FirstOrDefault(v => v.Id == id);
            if (marcaToDelete != null)
            {
                _ctx.Marcas.Remove(marcaToDelete);
            }
            _ctx.SaveChanges();
        }

        public void Update(Marca marca)
        {
            var existingMarca = Get(marca.Id);
            if (existingMarca == null)
            {
                return;
            }
            existingMarca.Nome = marca.Nome;
            _ctx.SaveChanges();
        }
    }
}
