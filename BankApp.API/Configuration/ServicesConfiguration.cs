using BankApp.BusinessLogic.Implementations;
using BankApp.BusinessLogic.Intefaces;
using BankApp.DataAccess.Repository.Implementation;
using BankApp.DataAccess.Repository.Interface;

namespace BankApp.API.Configuration
{
	public static class ServiceConfiguration
	{
		public static void AddServices(this IServiceCollection services)
		{
			services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>))
			.AddScoped<IUserService, UserService>();


		}
	}
}
