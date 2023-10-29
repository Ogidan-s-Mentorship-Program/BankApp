using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
	public class User : IdentityUser
	{

		public Guid Id { get; set; } = Guid.NewGuid();
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string Email { get; set; }
		public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
		public List<Address> Addresses { get; set; } = new List<Address>();
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
	}

	public enum Gender
	{
		Male,
		Female
	}
}
