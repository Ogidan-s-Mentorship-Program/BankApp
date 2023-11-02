using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Role)
                .HasMaxLength(50);

            builder.Property(s => s.Department)
                .HasMaxLength(50);

            builder.Property(s => s.UserId)
                .IsRequired();

        }
    }
}
