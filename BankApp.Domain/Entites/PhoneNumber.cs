using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
    public class PhoneNumber
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Extension { get; set; }
        public string Number { get; set; }
        public Guid UserId { get; set; }
    }
}
