using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class NextOfKin : User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string AccountId { get; set; }
        public Guid UserId { get; set; }
    }
}
