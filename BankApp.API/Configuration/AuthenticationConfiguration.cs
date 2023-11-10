using BankApp.BusinessLogic.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BankApp.API.Configuration
{
	public static class AuthenticationConfiguration
	{
		public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateAudience = true,
					ValidateIssuer = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidAudience = configuration["JWTSettings:Audience"],
					ValidIssuer = configuration["JWTSettings:Issuer"],
					IssuerSigningKey =
						new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTSettings:SecretKey"])),
					ClockSkew = TimeSpan.Zero
				};
			});

			services.AddAuthorization(options => options.AddPolicy("RequireAdminOnly", policy => policy.RequireRole(Constants.Roles.Admin)))
					.AddAuthorization(options => options.AddPolicy("RequireCustomerOnly", policy => policy.RequireRole(Constants.Roles.Customer)));
		}
	}
}
