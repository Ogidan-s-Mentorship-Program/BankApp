using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.AccountNumber)
                .HasMaxLength(20);

            builder.Property(a => a.Balance)
                .HasColumnType("decimal(18, 2)");

            builder.Property(a => a.AccountType)
                .HasMaxLength(50);

            builder.Property(a => a.BVN)
                .HasMaxLength(11);

            builder.Property(a => a.NIN)
                .HasMaxLength(14);

            builder.Property(a => a.AccountName)
                .HasMaxLength(100);

            builder.Property(a => a.HolderAddress)
                .HasMaxLength(255);

            builder.Property(a => a.IsActive)
                .HasDefaultValue(true);

            builder.Property(a => a.UserId)
                .IsRequired();

        }
    }
}
