using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zefa.Domain.Models;
using Zefa.Domain.Models.Restaurants;

namespace Zefa.Infrastrucutre.Persistance.Configurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(ModelConstants.Restaurant.MaxNameLength);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(ModelConstants.Restaurant.MaxAddressLength);

        builder.OwnsMany(e => e.Menu, i =>
        {
            i
                .Property(e => e.Name)
                .HasMaxLength(ModelConstants.Item.MaxNameLength)
                .IsRequired();

            i
                .Property(e => e.Description)
                .HasMaxLength(ModelConstants.Item.MaxDescriptionLength)
                .IsRequired();
        });

        builder.OwnsMany(e => e.Tables, t =>
        {
            t
                .Property(e => e.Name)
                .HasMaxLength(ModelConstants.Table.MaxNameLength)
                .IsRequired();
        });
    }
}