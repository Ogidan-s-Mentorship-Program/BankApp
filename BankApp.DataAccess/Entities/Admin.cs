using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Admin : User
    {
        public Guid Id { get; set; } 
        public string Role { get; set; }
        public Guid UserId { get; set; } 
        public string StaffId { get; set; }
    }
}
