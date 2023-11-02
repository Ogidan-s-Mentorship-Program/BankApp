using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class GuarantorConfiguration : IEntityTypeConfiguration<Guarantor>
    {
        public void Configure(EntityTypeBuilder<Guarantor> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.BVN)
                .HasMaxLength(11);

            builder.Property(g => g.NIN)
                .HasMaxLength(14);

            builder.Property(g => g.UserId)
                .IsRequired();

        
        }
    }
}
