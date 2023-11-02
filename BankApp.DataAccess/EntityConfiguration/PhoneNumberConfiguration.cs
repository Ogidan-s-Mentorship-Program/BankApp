using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Extension)
                .HasMaxLength(10);

            builder.Property(p => p.Number)
                .HasMaxLength(15);

            builder.Property(p => p.UserId)
                .IsRequired();

       
        }
    }
}
