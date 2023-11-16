using BankApp.BusinessLogic.Intefaces;
using BankApp.DTOs.RequestDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginRequestDTO loginRequestDTO)
        {
            var Response = await _authenticationService.LoginAsync(loginRequestDTO);
            if (Response.Success)
            {
                return Ok(Response);
            }
            return BadRequest(Response);
        }
    }
}
