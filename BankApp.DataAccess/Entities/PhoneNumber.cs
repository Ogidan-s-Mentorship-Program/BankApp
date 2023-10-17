using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class PhoneNumber
    {
        public string Extension { get; set; }
        public string Number { get; set; }
        public Guid UserId { get; set; }
    }
}
