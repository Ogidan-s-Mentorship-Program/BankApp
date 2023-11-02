using BankApp.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Repository.Implementation
{
	public class GenericRepo<T> : IGenericRepo<T> where T : class
	{

		public GenericRepo()
		{

		}
		public Task DeleteAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(T entityToDelete)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<T> GetByIdAysnc(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> InsertAsync(T entityToInsert)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(T entityToUpdate)
		{
			throw new NotImplementedException();
		}
	}
}
