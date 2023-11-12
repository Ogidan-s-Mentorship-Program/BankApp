using BankApp.DTOs.RequestDTOs;
using BankApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic.Intefaces
{
	public interface IUserService
	{
		Task<GenericResponse<string>> CreateUserAsync(CreateUserRequestDTO createUserRequestDTO);
	}
}
