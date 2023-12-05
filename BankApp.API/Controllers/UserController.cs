using BankApp.BusinessLogic.Intefaces;
using BankApp.Domain.Entites;
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

        [HttpPut("api/UpdatingUser/{userId}")]
        [ProducesResponseType(typeof(GenericResponse<string>), 200)]
        public async Task<IActionResult> UpdateUserAsync(string userId, [FromBody] UpdateUserRequestDTO updateUserRequestDTO)
        {
            var result = await _userService.UpdateUserAsync(userId, updateUserRequestDTO);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        //      [HttpPut("api/users/{userId}")]
        //      [ProducesResponseType(typeof (GenericResponse<string>), 200)]
        //public async Task<IActionResult> UpdateUserAsync(UpdateUserRequestDTO updateUserRequestDTO)
        //{
        //          var result = await _userService.UpdateUserAsync(updateUserRequestDTO);

        //          if (result.Success)
        //	{
        //		return Ok(result);
        //	}
        //	return BadRequest();
        //}
    }
}
