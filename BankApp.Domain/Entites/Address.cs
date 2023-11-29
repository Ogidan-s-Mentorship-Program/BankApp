using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class Address
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public string PostalCode { get; set; } = string.Empty;
		public string Street { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;

		public virtual User User { get; set; }

		[ForeignKey("UserId")]
		public virtual Guid UserId { get; set; } 
    }
}
