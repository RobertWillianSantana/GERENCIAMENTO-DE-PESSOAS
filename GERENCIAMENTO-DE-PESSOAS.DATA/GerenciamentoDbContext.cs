using GERENCIAMENTO_DE_PESSOAS.CORE.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GERENCIAMENTO_DE_PESSOAS.DATA
{
    public class GerenciamentoDbContext : DbContext
    {
        public GerenciamentoDbContext(DbContextOptions<GerenciamentoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}