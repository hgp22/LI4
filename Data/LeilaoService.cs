using UpShift.Models;


namespace UpShift.Data
{
    public class LeilaoService
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
            _timer = new Timer(ConcluirLeiloes, null, TimeSpan.Zero, _interval);
        }

        private void ConcluirLeiloes(object state)
        {
            Console.WriteLine("Verificando se os leilões acabaram...");

            List<Leilao> leiloes = _ctx.Leiloes.ToList();
            foreach (Leilao l in leiloes)
            {
                if (DateTime.Now.CompareTo(l.DataFinal) >= 0 && !l.LeilaoAcabou)
                {
                    Console.WriteLine($"Leilao {l.Id} Acabou!");
                    l.LeilaoAcabou = true;
                    Update(l, _ctx);
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

        public void Update(Leilao leilao, DataBaseContext context)
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

            context.SaveChanges();
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
