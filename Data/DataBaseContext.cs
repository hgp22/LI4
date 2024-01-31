using UpShift.Models;
using Microsoft.EntityFrameworkCore;

public class DataBaseContext : DbContext
{
	public DbSet<Marca> Marcas { get; set; }
	public DbSet<Modelo> Modelos { get; set; }
	public DbSet<Utilizador> Utilizadores { get; set; }
	public DbSet<Veiculo> Veiculos { get; set; }
	public DbSet<Licitacao> Licitacoes { get; set; }
	public DbSet<Leilao> Leiloes { get; set; }
	public DbSet<ClientMessage> ClientMessages { get; set; }

	public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Utilizador>().HasKey(u => u.Username);
		modelBuilder.Entity<Licitacao>()
		.Property(l => l.Valor)
		.HasColumnType("decimal(18, 0)");
	}
}


