using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
    public class Transactions
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public int TransactionId { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
		public DateTime TransactionDate { get; set; }
		public string Merchant { get; set; }
		public string PaymentMethod { get; set; }
		public string Category { get; set; }
		public string Currency { get; set; }
		public string Location { get; set; }
		public Guid UserId { get; set; }
	}
}
