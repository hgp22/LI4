using UpShift.Controllers;
using UpShift.Models;


namespace UpShift.Data
{
    public class LeilaoService : IHostedService, IDisposable
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(5);
        private Timer _timer;

        private List<Leilao> _leiloes;
        private VeiculoService _veiculoService;

        public LeilaoService(IServiceProvider serviceProvider, VeiculoService veiculoService)
        {
            Console.WriteLine("LeilaoService foi criado.");
            _leiloes = new List<Leilao>()
            {
                new Leilao(1, "Leilao A", null, 2000, 100, new DateTime(2024, 01, 30, 23, 59, 59), false, null, "Amazing Car", "admin123", 1, -1),
                new Leilao(2, "Leilao B", null, 5020, 200, new DateTime(2024, 01, 30, 23, 59, 59), false, null, "Luxury Car", "admin123", 2, -1)
            };

            _veiculoService = veiculoService;
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(VerificarLeiloes, null, TimeSpan.Zero, _interval);
            return Task.CompletedTask;
        }

        private void VerificarLeiloes(object state)
        {
            Console.WriteLine("Auction review method called");
            using (var scope = _serviceProvider.CreateScope())
            {
                var leilaoService = scope.ServiceProvider.GetRequiredService<LeilaoService>();
                leilaoService.ConcluirLeiloes();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public void ConcluirLeiloes()
        {
            List<Leilao> leiloes = _leiloes.ToList();
            foreach (Leilao l in leiloes)
            {
                if (DateTime.Now.CompareTo(l.DataFinal) >= 0)
                {
                    Console.WriteLine("Leilao Acabou!");
                    l.LeilaoAcabou = true;
                    Update(l);
                }
            }
        }

        public List<Leilao> GetAll()
        {
            return _leiloes.ToList();
        }

        public Leilao Get(int id)
        {
            return _leiloes.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Leilao leilao)
        {
            _leiloes.Add(leilao);
        }

        public void Delete(int id)
        {
            var leilaoToDelete = _leiloes.FirstOrDefault(v => v.Id == id);
            if (leilaoToDelete != null)
            {
                _leiloes.Remove(leilaoToDelete);
            }
        }

        public void Update(Leilao leilao)
        {
            var existingLeilao = Get(leilao.Id);
            if (existingLeilao == null)
            {
                return;
            }
            existingLeilao.Titulo = leilao.Titulo;
            existingLeilao.Fotografias = leilao.Fotografias;    
            existingLeilao.PrecoStart = leilao.PrecoStart;
            existingLeilao.BidMinima = leilao.BidMinima;
            existingLeilao.DataFinal = leilao.DataFinal;
            existingLeilao.LeilaoAcabou = leilao.LeilaoAcabou;
            existingLeilao.VideoLink = leilao.VideoLink;
            existingLeilao.Descricao = leilao.Descricao;
            existingLeilao.UsernameAdmin = leilao.UsernameAdmin;
            existingLeilao.IdVeiculo = leilao.IdVeiculo;
            existingLeilao.IdLicitacaoAtual = leilao.IdLicitacaoAtual;
        }

        public Veiculo GetVeiculo(int id)
        {
            return _veiculoService.Get(Get(id).IdVeiculo);
        }   
    }
}
