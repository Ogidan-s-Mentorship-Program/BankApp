using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
	public class PhoneNumberRequestDTO
	{
		public string Extension { get; set; }
		public string Number { get; set; }
		[JsonIgnore]
		public Guid UserId { get; set; }
	}
}
