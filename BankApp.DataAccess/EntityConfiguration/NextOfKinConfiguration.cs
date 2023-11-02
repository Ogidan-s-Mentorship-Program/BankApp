using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class NextOfKinConfiguration : IEntityTypeConfiguration<NextOfKin>
    {
        public void Configure(EntityTypeBuilder<NextOfKin> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.AccountId)
                .HasMaxLength(50);

            builder.Property(n => n.UserId)
                .IsRequired();

       
        }
    }
}
