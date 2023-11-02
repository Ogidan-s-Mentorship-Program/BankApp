using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BankApp.Data.EntityConfiguration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.HasKey(t => t.TransactionId);

            builder.Property(t => t.Description)
                .HasMaxLength(255);

            builder.Property(t => t.Amount)
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.TransactionDate)
                .HasColumnType("date");

            builder.Property(t => t.Merchant)
                .HasMaxLength(100);

            builder.Property(t => t.PaymentMethod)
                .HasMaxLength(50);

            builder.Property(t => t.Category)
                .HasMaxLength(50);

            builder.Property(t => t.Currency)
                .HasMaxLength(3);

            builder.Property(t => t.Location)
                .HasMaxLength(255);

            builder.Property(t => t.UserId)
                .IsRequired();

           
        }
    }
}
