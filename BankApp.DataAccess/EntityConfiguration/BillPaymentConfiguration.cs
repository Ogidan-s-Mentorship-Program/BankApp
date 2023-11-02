using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class BillPaymentConfiguration : IEntityTypeConfiguration<BillPayment>
    {
        public void Configure(EntityTypeBuilder<BillPayment> builder)
        {
            builder.HasKey(bp => bp.Id);

            builder.Property(bp => bp.Amount)
                .HasColumnType("decimal(18, 2)");

            builder.Property(bp => bp.Status)
                .HasMaxLength(50);

            builder.Property(bp => bp.Charges)
                .HasColumnType("decimal(18, 2)");

            builder.Property(bp => bp.PaymentDate)
                .HasColumnType("date");

            builder.Property(bp => bp.UserId)
                .IsRequired();

            builder.Property(bp => bp.TransactionId)
                .IsRequired();
        }
    }
}
