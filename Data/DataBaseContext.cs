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

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=DESKTOP-UTLMIHD\\LI4;Initial Catalog=LI4;Integrated Security=True;Encrypt=False");
	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Utilizador>().HasKey(u => u.Username);
    }
}


