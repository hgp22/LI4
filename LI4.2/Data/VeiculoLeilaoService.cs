using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Data
{
    public class VeiculoLeilaoService
    {
        private List<VeiculoLeilao> _veiculosLeilao;

        public VeiculoLeilaoService()
        {
            _veiculosLeilao = new List<VeiculoLeilao>
            {
                new VeiculoLeilao(1, "Carro A", 2022, "MarcaA", "ModeloA", "Descrição A", "Gasolina", "Vermelho",
                                  5, 5000, 2000, 150, 4, 50000, 10000, DateOnly.FromDateTime(DateTime.Now.AddDays(25)), false,
                                  new List<string> {}, new List<string> {}),

                new VeiculoLeilao(2, "Carro B", 2021, "MarcaB", "ModeloB", "Descrição B", "Diesel", "Azul",
                                  5, 6000, 2200, 180, 4, 60000, 12000, DateOnly.FromDateTime(DateTime.Now.AddDays(10)), false,
                                  new List<string> {}, new List<string> {})
            };
        }

        public List<VeiculoLeilao> GetAll()
        {
            return _veiculosLeilao.ToList();
        }

        public VeiculoLeilao Get(int id)
        {
            return _veiculosLeilao.FirstOrDefault(v => v.Id == id);
        }

        public void Add(VeiculoLeilao veiculo)
        {
            _veiculosLeilao.Add(veiculo);
        }

        public void Delete(int id)
        {
            var veiculoToDelete = _veiculosLeilao.FirstOrDefault(v => v.Id == id);
            if (veiculoToDelete != null)
            {
                _veiculosLeilao.Remove(veiculoToDelete);
            }
        }
    }
}

