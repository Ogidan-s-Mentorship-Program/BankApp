using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class PhoneNumber
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Extension { get; set; }
        public string Number { get; set; }
        public Guid UserId { get; set; }
    }
}
