using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Account
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        public string AccountNumber { get; set; }

        [Required] 
        public decimal Balance { get; set; }

        [Required]
        public string AccountType { get; set; }

        [StringLength(11)] 
        public string BVN { get; set; }

        [StringLength(11)] 
        public string NIN { get; set; }

        [Required] 
        public string AccountName { get; set; }

        public string HolderAddress { get; set; }

        public bool IsActive { get; set; }

        [Required] 
        public Guid UserId { get; set; }
    }
}
