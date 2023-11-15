using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
	public class PhoneNumberRequestDTO
	{
		[StringLength(5, ErrorMessage = "Extension cannot exceed 5 characters.")]
		public string Extension { get; set; }

		[Required(ErrorMessage = "Phone number is required.")]
		[RegularExpression(@"^\d{1,15}$", ErrorMessage = "Invalid phone number format.")]
		public string Number { get; set; }

		[JsonIgnore]
		public Guid UserId { get; set; }
	}
}
