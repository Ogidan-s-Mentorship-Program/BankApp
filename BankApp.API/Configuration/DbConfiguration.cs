using BankApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace BankApp.API.Configuration
{
	public static class DbConfiguration
	{
		public static void AddDbConfig(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
			 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		}
	}
}
