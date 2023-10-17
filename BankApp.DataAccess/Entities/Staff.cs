using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class Staff : User
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }

    }
}
