using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Staff : User
    {
        public new Guid Id { get; set; } 
        public string Role { get; set; }
        public string Department { get; set; }
    }
}
