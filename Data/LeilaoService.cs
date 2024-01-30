using UpShift.Models;


namespace UpShift.Data
{
    public class LeilaoService : IHostedService, IDisposable
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(5);
        private Timer _timer;

        private readonly DataBaseContext _ctx;  
        private VeiculoService _veiculoService;

        public LeilaoService(IServiceProvider serviceProvider, VeiculoService veiculoService, DataBaseContext ctx)
        {
            Console.WriteLine("LeilaoService foi criado.");
            
            _ctx = ctx;
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
            List<Leilao> leiloes = _ctx.Leiloes.ToList();
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
            return _ctx.Leiloes.ToList();
        }

        public Leilao Get(int id)
        {
            return _ctx.Leiloes.FirstOrDefault(v => v.Id == id);
        }

        public void Add(Leilao leilao)
        {
            _ctx.Leiloes.Add(leilao);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var leilaoToDelete = _ctx.Leiloes.FirstOrDefault(v => v.Id == id);
            if (leilaoToDelete != null)
            {
                _ctx.Leiloes.Remove(leilaoToDelete);
                _ctx.SaveChanges();
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
            existingLeilao.ValorInicial = leilao.ValorInicial;
            existingLeilao.AumentoMinimo = leilao.AumentoMinimo;
            existingLeilao.DataFinal = leilao.DataFinal;
            existingLeilao.LeilaoAcabou = leilao.LeilaoAcabou;
            existingLeilao.VideoLink = leilao.VideoLink;
            existingLeilao.Descricao = leilao.Descricao;
            existingLeilao.UsernameAdmin = leilao.UsernameAdmin;
            existingLeilao.IdVeiculo = leilao.IdVeiculo;
            existingLeilao.IdLicitacaoAtual = leilao.IdLicitacaoAtual;

            _ctx.SaveChanges();
        }

        public Veiculo GetVeiculo(int id)
        {
            return _veiculoService.Get(Get(id).IdVeiculo);
        }   
    }
}
