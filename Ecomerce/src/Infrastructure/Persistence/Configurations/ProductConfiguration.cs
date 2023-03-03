using Ecomerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecomerce.Infrastructure.Persistence.Configurations;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property<string>(e=>e.Name).IsRequired()
            .HasMaxLength(50);
        builder.Property<float>(e => e.Price).IsRequired();

        builder.HasOne<Category>(e => e.Category)
            .WithMany(e => e.Products).HasForeignKey(e => e.Id);
    }
}