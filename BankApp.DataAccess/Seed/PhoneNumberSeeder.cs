using BankApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Seed
{
    internal class PhoneNumberSeeder
    {
        private readonly AppDbContext _context;

        public PhoneNumberSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (!_context.PhoneNumbers.Any())
            {
                // Add initial phone number data
                var phoneNumbers = new[]
                {
                new PhoneNumber
                {
                    Id = Guid.NewGuid(),
                    Extension = "+1",
                    Number = "555-123-4567",
                    UserId = Guid.NewGuid()
                },
                new PhoneNumber
                {
                    Id = Guid.NewGuid(),
                    Extension = "+44",
                    Number = "20-1234-5678",
                    UserId = Guid.NewGuid()
                },
                // Add more phone number entries as needed
            };

                _context.PhoneNumbers.AddRange(phoneNumbers);
                _context.SaveChanges();
            }
        }
    }
}
