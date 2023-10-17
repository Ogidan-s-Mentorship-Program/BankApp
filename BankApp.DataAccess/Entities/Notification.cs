using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
