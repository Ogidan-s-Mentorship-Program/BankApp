using BankApp.BusinessLogic.Intefaces;
using BankApp.DTOs;
using BankApp.DTOs.RequestDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("UserCreation")]
		[ProducesResponseType(typeof(GenericResponse<string>), 200)]
		public async Task<IActionResult> UserCreationAsync(CreateUserRequestDTO createUserRequestDTO)
		{
			var result = await _userService.CreateUserAsync(createUserRequestDTO);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest();
		}

	}
}
