using BankApp.BusinessLogic.Intefaces;
using BankApp.Domain.Entites;
using BankApp.DTOs;
using BankApp.DTOs.RequestDTOs;
using BankApp.DTOs.ResponseDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic.Implementations 
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenGenerator _tokenGenerator;
        public AuthenticationService(UserManager<User> userManager, ITokenGenerator tokenGenerator)
        {
            _userManager = userManager;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<GenericResponse<LoginResponseDTO>> LoginAsync(LoginRequestDTO loginRequestDTO)
        {
            var UserExist = await _userManager.FindByEmailAsync(loginRequestDTO.Email);
            if (UserExist != null) 
            {
                if (await _userManager.CheckPasswordAsync(UserExist, loginRequestDTO.Password))
                {
                    if (UserExist.EmailConfirmed)
                    {
                        LoginResponseDTO LoginResponseDTO = new LoginResponseDTO()
                        {
                            Id = Guid.Parse(UserExist.Id),
                            Email = UserExist.Email,
                            FullName = $"{UserExist.FirstName} {UserExist.LastName}",
                            Token = await _tokenGenerator.GenerateTokenAsync(UserExist)

                        };
                        return GenericResponse<LoginResponseDTO>.SuccessResponse(LoginResponseDTO, "Login Succesful");
                    }
                    return GenericResponse<LoginResponseDTO>.ErrorResponse("Kindly confirmed your email login");

                }
                return GenericResponse<LoginResponseDTO>.ErrorResponse("Email does not exist");

            }
            return GenericResponse<LoginResponseDTO>.ErrorResponse("User does not exist");
        }
    }
}
