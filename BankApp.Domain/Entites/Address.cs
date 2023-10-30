using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Address
    {
		public Guid Id { get; set; } 
		public string PostalCode { get; set; } = string.Empty;
		public string MainAddress { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		public string UserId { get; set; } = string.Empty;
    }
}
