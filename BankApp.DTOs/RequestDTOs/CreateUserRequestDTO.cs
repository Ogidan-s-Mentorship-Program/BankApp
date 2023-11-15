using BankApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
	public class CreateUserRequestDTO
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string Gender { get; set; }
		public List<PhoneNumberRequestDTO> PhoneNumbers { get; set; } = new List<PhoneNumberRequestDTO>();
		public List<AddressRequestDTO> Addresses { get; set; } = new List<AddressRequestDTO>();
		public string BVN { get; set; }
		public string NIN { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		[Compare("Password", ErrorMessage = "Password do not match")]
		public string ConfirmedPassword { get; set; }
	}
	public enum Gender
	{
		Male,
		Female
	}
}
