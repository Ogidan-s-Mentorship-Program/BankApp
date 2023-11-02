using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class ActivityLogEntryConfiguration : IEntityTypeConfiguration<ActivityLogEntry>
    {
        public void Configure(EntityTypeBuilder<ActivityLogEntry> builder)
        {
            builder.HasKey(a => a.LogEntryId);

            builder.Property(a => a.User)
                .HasMaxLength(50);

            builder.Property(a => a.Details)
                .HasMaxLength(255);

            builder.Property(a => a.RequestData)
                .HasMaxLength(255);

            builder.Property(a => a.ResponseData)
                .HasMaxLength(255);

            builder.Property(a => a.EventSource)
                .HasMaxLength(50);

            builder.Property(a => a.EventType)
                .IsRequired();

            builder.Property(a => a.Result)
                .IsRequired();

            builder.Property(a => a.Duration)
                .HasColumnType("time");

            builder.Property(a => a.TransactionType)
                .IsRequired(false);

      
        }
    }
}
