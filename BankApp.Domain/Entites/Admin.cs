using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Admin
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Role { get; set; }
		public Guid UserId { get; set; }
		public string StaffId { get; set; }
    }
}
