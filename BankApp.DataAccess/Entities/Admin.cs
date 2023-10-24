using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Admin : User
    {
        [Key] 
        public Guid Id { get; set; }

        [Required] 
        public string Role { get; set; }

        [Required] 
        public Guid UserId { get; set; }

        [Required] 
        public string StaffId { get; set; }
    }
}
