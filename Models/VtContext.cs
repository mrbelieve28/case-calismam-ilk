using Microsoft.EntityFrameworkCore;

namespace casecalismam.Models
{
    public class VtContext : DbContext
    {
        public VtContext(DbContextOptions<VtContext> option) : base(option)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
