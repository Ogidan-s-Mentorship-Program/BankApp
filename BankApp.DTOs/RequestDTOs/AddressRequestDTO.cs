using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
	public class AddressRequestDTO
	{
		public string PostalCode { get; set; } = string.Empty;
		public string Street { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		[JsonIgnore]
		public Guid UserId { get; set; } 
	}
}
