using BankApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace BankApp.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.MiddleName)
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasAnnotation("EmailAddress", true);

            builder.Property(u => u.Gender)
                .HasConversion<string>()
                .HasMaxLength(10);

            builder.Property(u => u.DateOfBirth)
                .HasColumnType("date");

           
        }
    }
}
