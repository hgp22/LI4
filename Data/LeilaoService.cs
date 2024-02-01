using Microsoft.EntityFrameworkCore;
using UpShift.Models;


namespace UpShift.Data
{
    public class LeilaoService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(40);
        private Timer _timer;

        private readonly DataBaseContext _ctx;
        private VeiculoService _veiculoService;

        public LeilaoService(IServiceProvider serviceProvider, VeiculoService veiculoService, DataBaseContext ctx)
        {
            Console.WriteLine("LeilaoService foi criado.");

            _ctx = ctx;
            _veiculoService = veiculoService;
            _timer = new Timer(async state => await ConcluirLeiloesAsync(state), null, TimeSpan.Zero, _interval);
        }

        private async Task ConcluirLeiloesAsync(object state)
        {
            Console.WriteLine("Verificando se os leilões acabaram...");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            using (var context = new DataBaseContext(optionsBuilder.Options))
            {
                var leiloesAConcluir = context.Leiloes
                    .Where(l => DateTime.Now.CompareTo(l.DataFinal) >= 0 && !l.LeilaoAcabou)
                    .ToList();

                foreach (var leilao in leiloesAConcluir)
                {
                    Console.WriteLine($"Leilao {leilao.Id} Acabou!");
                    leilao.LeilaoAcabou = true;
                    await UpdateAsync(leilao, context);
                }
            }
        }

        public async Task UpdateAsync(Leilao leilao, DataBaseContext context)
        {
            var existingLeilao = context.Leiloes.FirstOrDefault(v => v.Id == leilao.Id);
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

            await context.SaveChangesAsync();
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

        public async Task Update(Leilao leilao, DataBaseContext context)
        {
            var existingLeilao = context.Leiloes.FirstOrDefault(v => v.Id == leilao.Id);
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

            await context.SaveChangesAsync();
        }

        public Veiculo GetVeiculo(int id)
        {
            return _veiculoService.Get(Get(id).IdVeiculo);
        }   
    }
}
