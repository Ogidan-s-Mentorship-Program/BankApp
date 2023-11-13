using BankApp.BusinessLogic.Intefaces;
using BankApp.BusinessLogic.Utilities;
using BankApp.Domain.Entites;
using BankApp.DTOs;
using BankApp.DTOs.RequestDTOs;
using Microsoft.AspNetCore.Identity;

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
			var EmailExist = await _userManager.FindByEmailAsync(createUserRequestDTO.Email);
			if (EmailExist == null)
			{
				User user = new()
				{
					FirstName = createUserRequestDTO.FirstName,
					LastName = createUserRequestDTO.LastName,
					Email = createUserRequestDTO.Email,
					UserName = createUserRequestDTO.Email.Split('@')[0],
					EmailConfirmed = true
				};

				IdentityResult result = await _userManager.CreateAsync(user, createUserRequestDTO.Password);
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
					return GenericResponse<string>.SuccessResponse("User Creation successful", "Sucessful");

				}
				return GenericResponse<string>.ErrorResponse("User Creation fail");
			}
			return GenericResponse<string>.ErrorResponse("Email already exist");
		}
	}
}
