using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Customer
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid UserId { get; set; }
	}
}
