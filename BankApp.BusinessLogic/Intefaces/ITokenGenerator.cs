using BankApp.Domain.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic.Intefaces
{
    public interface ITokenGenerator
    {
        Task<string> GenerateTokenAsync(User user);
    }
}
