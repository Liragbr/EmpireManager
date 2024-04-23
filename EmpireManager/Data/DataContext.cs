using Microsoft.EntityFrameworkCore;
using EmpireManager.Domain;

namespace EmpireManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definindo a chave primária para a entidade ItemVenda
            modelBuilder.Entity<ItemVenda>()
                .HasKey(iv => new { iv.ProdutoId, iv.VendaID }); // Substitua por sua chave primária
        }
    }
}
