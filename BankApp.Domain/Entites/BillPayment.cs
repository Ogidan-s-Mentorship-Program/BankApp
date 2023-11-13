using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class BillPayment
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid UserId { get; set; }
		public decimal Amount { get; set; }
		public string Status { get; set; }
		public Guid TransactionId { get; set; }
		public decimal Charges { get; set; }
		public DateTime PaymentDate { get; set; }
    }
}
