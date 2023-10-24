using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Staff : User
    {
        [Key] 
        public new Guid Id { get; set; }

        [Required] 
        public string Role { get; set; }

        [Required] 
        public string Department { get; set; }
    }
}
