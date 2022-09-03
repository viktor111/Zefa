using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zefa.Domain.Models;
using Zefa.Domain.Models.Restaurateurs;

namespace Zefa.Infrastrucutre.Persistance.Configurations;

public class RestaurateurConfiguration : IEntityTypeConfiguration<Restaurateur>
{
    public void Configure(EntityTypeBuilder<Restaurateur> builder)
    {
        builder.HasKey(e => e.Id);

        builder.OwnsOne(e => e.PersonalInformation, p =>
        {
            p.WithOwner();

            p.Property(e => e.Email)
                .HasMaxLength(ModelConstants.PersonalInformation.MaxEmailLength)
                .IsRequired();
            
            p.Property(e => e.BirthDate)
                .IsRequired();
            
            p.Property(e => e.FirstName)
                .HasMaxLength(ModelConstants.PersonalInformation.MaxFirstNameLength)
                .IsRequired();
            
            p.Property(e => e.LastName)
                .HasMaxLength(ModelConstants.PersonalInformation.MaxLastNameLength)
                .IsRequired();
            
            p.Property(e => e.PhoneNumber)
                .HasMaxLength(ModelConstants.PersonalInformation.MaxPhoneNumberLength)
                .IsRequired();
        });
    }
}