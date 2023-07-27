using casecalismam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace casecalismam.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i=>i.Name).IsRequired(true);

            builder.Property(i=>i.Price).IsRequired(true);

            builder.Property(i => i.Stok).IsRequired(true);
        }
    }
}
