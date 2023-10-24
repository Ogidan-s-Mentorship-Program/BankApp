using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class NextOfKin : User
    {
        [Key] 
        public new Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        public string AccountId { get; set; }

        [Required] 
        public Guid UserId { get; set; }
    }
}
