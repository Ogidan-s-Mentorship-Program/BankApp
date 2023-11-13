using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Staff 
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Role { get; set; }
		public string Department { get; set; }
		public Guid UserId { get; set; }
    }
}
