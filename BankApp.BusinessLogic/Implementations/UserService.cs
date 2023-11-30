using BankApp.BusinessLogic.Intefaces;
using BankApp.BusinessLogic.Utilities;
using BankApp.Domain.Entites;
using BankApp.DTOs;
using BankApp.DTOs.RequestDTOs;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;

namespace BankApp.BusinessLogic.Implementations
{
	public class UserService : IUserService
	{
		private readonly UserManager<User> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public UserService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public async Task<GenericResponse<string>> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO)
		{
			var emailExists = await _userManager.FindByEmailAsync(createUserRequestDTO.Email);
			if (emailExists == null)
			{
				User user = new()
				{
					FirstName = createUserRequestDTO.FirstName,
					LastName = createUserRequestDTO.LastName,
					MiddleName = createUserRequestDTO.MiddleName,
					UserName = createUserRequestDTO.Email.Split('@')[0],
					Email = createUserRequestDTO.Email,
					Gender = createUserRequestDTO.Gender,
					BVN = createUserRequestDTO.BVN,
					NIN = createUserRequestDTO.NIN,
					DateOfBirth = createUserRequestDTO.DateOfBirth,
					EmailConfirmed = true,
				};

				user.PhoneNumbers = createUserRequestDTO.PhoneNumbers.Select(phoneNumberDTO => new PhoneNumber
				{
					Extension = phoneNumberDTO.Extension,
					Number = phoneNumberDTO.Number,
					UserId = Guid.Parse(user.Id),
				}).ToList();

				user.Addresses = createUserRequestDTO.Addresses.Select(addressDTO => new Address
				{
					Street = addressDTO.Street,
					City = addressDTO.City,
					State = addressDTO.State,
					Country = addressDTO.Country,
					PostalCode = addressDTO.PostalCode,
					UserId = Guid.Parse(user.Id)
				}).ToList();

				var result = await _userManager.CreateAsync(user, createUserRequestDTO.Password);

				if (result.Succeeded)
				{
					if (!await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
					{
						await _roleManager.CreateAsync(new IdentityRole(Constants.Roles.Customer));
					}

					if (await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
					{
						await _userManager.AddToRoleAsync(user, Constants.Roles.Customer);
					}

					return GenericResponse<string>.SuccessResponse("User creation successful", "Successful");
				}

				return GenericResponse<string>.ErrorResponse("User creation failed");
			}

			return GenericResponse<string>.ErrorResponse("Email already exists");
		}


		//	public async Task<GenericResponse<string>> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO)
		//	{
		//		// Check if the email already exists
		//		var emailExists = await _userManager.FindByEmailAsync(createUserRequestDTO.Email);
		//		if (emailExists == null)
		//		{
		//			// Create a new user
		//			User user = new()
		//			{
		//				FirstName = createUserRequestDTO.FirstName,
		//				LastName = createUserRequestDTO.LastName,
		//				MiddleName = createUserRequestDTO.MiddleName,
		//				UserName = createUserRequestDTO.Email.Split('@')[0],
		//				Email = createUserRequestDTO.Email,
		//				Gender = createUserRequestDTO.Gender,
		//				BVN = createUserRequestDTO.BVN,
		//				NIN = createUserRequestDTO.NIN,
		//				DateOfBirth = createUserRequestDTO.DateOfBirth,
		//				EmailConfirmed = true,

		//			};

		//			// Add phone numbers
		//			foreach (var phoneNumber in createUserRequestDTO.PhoneNumbers)
		//			{
		//				user.PhoneNumbers.Add(new PhoneNumber
		//				{
		//					Extension = phoneNumber.Extension,
		//					Number = phoneNumber.Number,
		//					UserId = user.Id
		//				});
		//			}

		//			// Add addresses
		//			foreach (var address in createUserRequestDTO.Addresses)
		//			{
		//				user.Addresses.Add(new Address
		//				{						
		//					Street = address.Street,
		//					City = address.City,
		//					State = address.State,
		//					Country = address.Country,
		//					PostalCode = address.PostalCode,
		//					UserId = user.Id
		//				});
		//			}

		//			// Perform user creation
		//			var result = await _userManager.CreateAsync(user, createUserRequestDTO.Password);

		//			if (result.Succeeded)
		//			{
		//				// Check and create role
		//				if (!await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
		//				{
		//					await _roleManager.CreateAsync(new IdentityRole(Constants.Roles.Customer));
		//				}

		//				// Add user to role
		//				if (await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
		//				{
		//					await _userManager.AddToRoleAsync(user, Constants.Roles.Customer);
		//				}

		//				return GenericResponse<string>.SuccessResponse("User creation successful", "Successful");
		//			}

		//			return GenericResponse<string>.ErrorResponse("User creation failed");
		//		}

		//		return GenericResponse<string>.ErrorResponse("Email already exists");
		//	}
		//}
	}
}
