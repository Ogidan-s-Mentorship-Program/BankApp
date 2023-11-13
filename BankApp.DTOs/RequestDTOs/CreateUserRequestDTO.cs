﻿using BankApp.Domain.Entites;
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
		public string Email { get; set; }
		public string Password { get; set; }
		//public string MiddleName { get; set; }
		//[Compare("Password", ErrorMessage ="Password do not match")]
		//public string ConfirmedPassword { get; set; }
	}
}
