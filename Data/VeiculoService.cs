using UpShift.Models;

namespace UpShift.Data
{
    public class VeiculoService
    {
        private readonly DataBaseContext _ctx;

        public VeiculoService(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public List<Veiculo> GetAll()
        {
            return _ctx.Veiculos.ToList();
        }

        public Veiculo Get(int id)
        {
            return _ctx.Veiculos.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Veiculo veiculo)
        {
            _ctx.Veiculos.Add(veiculo);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var veiculoToDelete = _ctx.Veiculos.FirstOrDefault(v => v.Id == id);
            if (veiculoToDelete != null)
            {
                _ctx.Veiculos.Remove(veiculoToDelete);
            }
            _ctx.SaveChanges();
        }

        public bool Update(Veiculo veiculo)
        {
            var existingVeiculo = Get(veiculo.Id);
            if (existingVeiculo == null)
            {
                return false;
            }
            existingVeiculo.Ano = veiculo.Ano;
            existingVeiculo.IdMarca = veiculo.IdMarca;
            existingVeiculo.IdModelo = veiculo.IdModelo;
            existingVeiculo.TipoMotor = veiculo.TipoMotor;
            existingVeiculo.CorExterior = veiculo.CorExterior;
            existingVeiculo.Quilometragem = veiculo.Quilometragem;
            existingVeiculo.Cilindrada = veiculo.Cilindrada;
            existingVeiculo.Potencia = veiculo.Potencia;
            existingVeiculo.NumPortas = veiculo.NumPortas;
            existingVeiculo.Lugares = veiculo.Lugares;

            _ctx.SaveChanges();

            return true;
        }
    }
}
