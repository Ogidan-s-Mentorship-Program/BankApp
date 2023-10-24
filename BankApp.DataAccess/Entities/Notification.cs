using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Notification
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        public string Message { get; set; }

        [Required] 
        public Guid UserId { get; set; }

        public bool IsRead { get; set; }
    }
}
