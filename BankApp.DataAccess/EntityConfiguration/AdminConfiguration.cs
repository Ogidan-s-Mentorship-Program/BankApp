using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Data.EntityConfiguration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Role)
                .HasMaxLength(50);

            builder.Property(a => a.StaffId)
                .HasMaxLength(50);

            builder.Property(a => a.UserId)
                .IsRequired();

        }
    }
}
