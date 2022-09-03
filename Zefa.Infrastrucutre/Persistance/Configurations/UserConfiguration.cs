using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zefa.Infrastrucutre.Identity;

namespace Zefa.Infrastrucutre.Persistance.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder
            .HasOne(u => u.Restaurateur)
            .WithOne()
            .HasForeignKey<User>("RestaurateurId")
            .OnDelete(DeleteBehavior.Restrict);
    }
}