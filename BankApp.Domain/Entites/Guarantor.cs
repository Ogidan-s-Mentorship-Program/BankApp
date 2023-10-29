using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Guarantor 
	{
		public new Guid Id { get; set; } = Guid.NewGuid();
		public Guid LoanId { get; set; }
		public string BVN { get; set; }
		public string NIN { get; set; }
		public Guid UserId { get; set; }
	}
}
