using BankApp.DTOs.RequestDTOs;
using BankApp.DTOs.ResponseDTOs;
using BankApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic.Intefaces
{
    public interface IAuthenticationService
    {
        Task<GenericResponse<LoginResponseDTO>> LoginAsync(LoginRequestDTO loginRequestDTO);
    }
}
