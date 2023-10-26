using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Guarantor : User
    {
        public new Guid Id { get; set; } = Guid.NewGuid();
        public Guid LoanId { get; set; } 
        public string BVN { get; set; }
        public string NIN { get; set; }
        public Guid UserId { get; set; }
    }
}
