using Ecomerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecomerce.Infrastructure.Persistence.Configurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property<string>(e => e.Name).HasMaxLength(30)
            .IsRequired();
        builder.Property<string>(e => e.Image).IsRequired();
        builder.HasMany<Product>(e => e.Products)
            .WithOne(e => e.Category).HasForeignKey(e => e.Id);
    }
}