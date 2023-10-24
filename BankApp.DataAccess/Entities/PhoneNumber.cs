using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class PhoneNumber
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(10)] 
        public string Extension { get; set; }

        [Required] 
        [MaxLength(15)] 
        public string Number { get; set; }

        [Required] 
        public Guid UserId { get; set; }
    }
}
