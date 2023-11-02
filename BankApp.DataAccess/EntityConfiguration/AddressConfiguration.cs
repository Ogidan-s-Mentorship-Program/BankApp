using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.PostalCode)
                .HasMaxLength(10);

            builder.Property(a => a.MainAddress)
                .HasMaxLength(255);

            builder.Property(a => a.City)
                .HasMaxLength(50);

            builder.Property(a => a.State)
                .HasMaxLength(50);

            builder.Property(a => a.Country)
                .HasMaxLength(50);

            builder.Property(a => a.UserId)
                .IsRequired();

        
        }
    }
}
