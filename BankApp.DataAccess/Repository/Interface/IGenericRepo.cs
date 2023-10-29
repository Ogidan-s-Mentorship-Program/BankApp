using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Repository.Interface
{
	public interface IGenericRepo<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAysnc(Guid id);
		Task<bool> InsertAsync(T entityToInsert);
		Task UpdateAsync(T entityToUpdate);
		Task DeleteAsync(Guid id);
		Task DeleteAsync(T entityToDelete);
	}
}
