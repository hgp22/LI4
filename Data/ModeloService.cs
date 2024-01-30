using UpShift.Models;

namespace UpShift.Data
{
    public class ModeloService
    {
        private readonly DataBaseContext _ctx;
        public ModeloService (DataBaseContext ctx)
        {
            _ctx = ctx;
        }
        public List<Modelo> GetAll()
        {
            return _ctx.Modelos.ToList();
        }

        public Modelo Get(int id)
        {
            return _ctx.Modelos.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Modelo modelo)
        {
            _ctx.Modelos.Add(modelo);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var modeloToDelete = _ctx.Modelos.FirstOrDefault(v => v.Id == id);
            if (modeloToDelete != null)
            {
                _ctx.Modelos.Remove(modeloToDelete);
            }
            _ctx.SaveChanges();
        }

        public void Update(Modelo modelo)
        {
            var existingModelo = Get(modelo.Id);
            if (existingModelo == null)
            {
                return;
            }
            existingModelo.Nome = modelo.Nome;
            _ctx.SaveChanges();
        }
    }
}
