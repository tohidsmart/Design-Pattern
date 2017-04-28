using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	interface IRepository<T>
	{
		void Insert(T entity);
		void Delete(T entity);
		IQueryable<T> GetAll();
		IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
		T GetByID(int Id);
	}
}
