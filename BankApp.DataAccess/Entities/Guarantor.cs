using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Guarantor : User
    {
        [Key] 
        public new Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        public Guid LoanId { get; set; }

        [Required] 
        [StringLength(11)] 
        public string BVN { get; set; }

        [Required] 
        [StringLength(11)]
        public string NIN { get; set; }

        [Required] 
        public Guid UserId { get; set; }
    }
}
