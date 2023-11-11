using BankApp.DataAccess.Context;
using BankApp.Domain.Entites;
using Microsoft.AspNetCore.Identity;
using System;

namespace BankApp.API.Configuration
{
	public static class IdentityConfiguration
	{
		public static void ConfigureIdentity(this IServiceCollection services)
		{
			services.AddIdentity<User, IdentityRole>(x =>
			{
				x.Password.RequireUppercase = true;
				x.Password.RequiredLength = 8;
				x.Password.RequireDigit = true;
				x.SignIn.RequireConfirmedEmail = true;
			})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();
		}
	}
}
