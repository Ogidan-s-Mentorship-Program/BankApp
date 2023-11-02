using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.LoanConfiguration
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.LoanType)
                .HasMaxLength(50);

            builder.Property(l => l.LoanAmount)
                .HasColumnType("decimal(18, 2)");

            builder.Property(l => l.OutstandingBalance)
                .HasColumnType("decimal(18, 2)");

            builder.Property(l => l.InterestRate)
                .HasColumnType("decimal(5, 2)");

            builder.Property(l => l.NextPaymentDueDate)
                .HasColumnType("date");

            builder.Property(l => l.UserId)
                .IsRequired();

   
        }
    }
}
