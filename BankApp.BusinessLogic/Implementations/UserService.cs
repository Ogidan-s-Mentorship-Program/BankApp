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
<<<<<<< HEAD
			return GenericResponse<string>.ErrorResponse("Email already exist");
		}

        //public async Task<GenericResponse<string>> UpdateUserAsync(string userId, UpdateUserRequestDTO updateUserRequestDTO)
        //{
        //    User user = await _userManager.FindByIdAsync(userId);

        //    if (user == null)
        //    {
        //        return GenericResponse<string>.ErrorResponse("User not found");
        //    }

        //    user.FirstName = updateUserRequestDTO.FirstName;
        //    user.LastName = updateUserRequestDTO.LastName;
        //    user.MiddleName = updateUserRequestDTO.MiddleName;
        //    user.Email = updateUserRequestDTO.Email;
        //    user.PhoneNumbers = updateUserRequestDTO.PhoneNumbers;
        //    user.Addresses = updateUserRequestDTO.Addresses;
        //    user.DateOfBirth = updateUserRequestDTO.DateOfBirth;




        //    IdentityResult result = await _userManager.UpdateAsync(user);

        //    if (result.Succeeded)
        //    {
        //        return GenericResponse<string>.SuccessResponse("User updated successfully", "Sucessful");
        //    }

        //    return GenericResponse<string>.ErrorResponse("Failed to update user");
        //}
        public async Task<GenericResponse<string>> UpdateUserAsync(string userId, UpdateUserRequestDTO updateUserRequestDTO)
        {
            Console.WriteLine($"Attempting to update user. UserId: {userId}");

            User user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return GenericResponse<string>.ErrorResponse("User not found");
            }

            user.FirstName = updateUserRequestDTO.FirstName;
            user.LastName = updateUserRequestDTO.LastName;
            user.MiddleName = updateUserRequestDTO.MiddleName;
            user.Email = updateUserRequestDTO.Email;
            user.Gender = updateUserRequestDTO.Gender.ToString();
            user.Addresses.Clear();
            user.Addresses.Add(updateUserRequestDTO.Addresses); 
            user.PhoneNumbers.Clear();
            user.PhoneNumbers.Add(updateUserRequestDTO.PhoneNumbers); 
            user.DateOfBirth = updateUserRequestDTO.DateOfBirth;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                Console.WriteLine($"User updated successfully. UserId: {userId}");
                return GenericResponse<string>.SuccessResponse("User updated successfully", "Successful");
            }

            return GenericResponse<string>.ErrorResponse("Failed to update user");
        }


    }
=======

			return GenericResponse<string>.ErrorResponse("Email already exists");
		}		
	}
>>>>>>> master
}
