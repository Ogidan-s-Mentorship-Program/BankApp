using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
	public class AddressRequestDTO
	{
		[StringLength(5, ErrorMessage = "Postal code cannot exceed 5 characters.")]
		public string PostalCode { get; set; } = string.Empty;

		[Required(ErrorMessage = "Street is required.")]
		public string Street { get; set; } = string.Empty;

		[Required(ErrorMessage = "City is required.")]
		public string City { get; set; } = string.Empty;

		public string State { get; set; } = string.Empty;

		[Required(ErrorMessage = "Country is required.")]
		public string Country { get; set; } = string.Empty;

		//[JsonIgnore]
		public Guid UserId { get; set; }
	}
}
