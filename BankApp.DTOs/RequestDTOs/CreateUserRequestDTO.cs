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
		[Required(ErrorMessage = "First name is required.")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Last name is required.")]
		public string LastName { get; set; }

		public string MiddleName { get; set; }

		[Required(ErrorMessage = "Gender is required.")]
		[RegularExpression(@"^(Male|Female|male|female)$", ErrorMessage = "Invalid Gender, Gender must be either Male, or Female.")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Phone numbers are required.")]
		[MinLength(1, ErrorMessage = "At least one phone number is required.")]
		public List<PhoneNumberRequestDTO> PhoneNumbers { get; set; } = new List<PhoneNumberRequestDTO>();

		[Required(ErrorMessage = "Addresses are required.")]
		[MinLength(1, ErrorMessage = "At least one address is required.")]
		public List<AddressRequestDTO> Addresses { get; set; } = new List<AddressRequestDTO>();

		[Required(ErrorMessage = "BVN is required.")]
		public string BVN { get; set; }

		[Required(ErrorMessage = "NIN is required.")]
		public string NIN { get; set; }

		[Required(ErrorMessage = "Date of birth is required.")]
		public DateTime DateOfBirth { get; set; }

		[RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
			+ "@"
			+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
			ErrorMessage = "You have entered an invalid email address")]
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
		   ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character")]
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "Passwords do not match.")]
		public string ConfirmedPassword { get; set; }
	}

	public enum Gender
	{
		[Display(Name = "Male")]
		Male,

		[Display(Name = "Female")]
		Female
	}
}
