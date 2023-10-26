using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Message { get; set; }
        public Guid UserId { get; set; }
        public bool IsRead { get; set; }
    }
}
