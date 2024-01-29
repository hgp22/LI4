using UpShift.Models;

namespace UpShift.Data
{
    public class VeiculoService
    {
        private List<Veiculo> _veiculos;

        public VeiculoService()
        {
            _veiculos = new List<Veiculo>
            {
                new Veiculo(1, 2019, 10000, "Preto", 4, 2000, 200, 5, 1, 2, 2),
                new Veiculo(2, 2018, 20000, "Branco", 4, 2000, 200, 5, 1, 3, 1)
            };
        }

        public List<Veiculo> GetAll()
        {
            return _veiculos.ToList();
        }

        public Veiculo Get(int id)
        {
            return _veiculos.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Veiculo veiculo)
        {
            _veiculos.Add(veiculo);
        }

        public void Delete(int id)
        {
            var veiculoToDelete = _veiculos.FirstOrDefault(v => v.Id == id);
            if (veiculoToDelete != null)
            {
                _veiculos.Remove(veiculoToDelete);
            }
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
            existingVeiculo.Combustivel = veiculo.Combustivel;
            existingVeiculo.CorExterior = veiculo.CorExterior;
            existingVeiculo.Quilometragem = veiculo.Quilometragem;
            existingVeiculo.Cilindrada = veiculo.Cilindrada;
            existingVeiculo.Potencia = veiculo.Potencia;
            existingVeiculo.NumPortas = veiculo.NumPortas;
            existingVeiculo.Lugares = veiculo.Lugares;

            return true;
        }
    }
}
