using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class NextOfKin : User
    {
        public new Guid Id { get; set; } = Guid.NewGuid();
        public string AccountId { get; set; }
        public Guid UserId { get; set; }
    }
}
