using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	class Repository<T> : IRepository<T> where T : class, IEntity
	{

		Table<T> Entity;

		public Repository(Table<T> entity)
		{
			Entity = entity;
		}

		public void Insert(T entity) => Entity.InsertOnSubmit(entity);


		public void Delete(T entity) => Entity.DeleteOnSubmit(entity);


		public IQueryable<T> GetAll() => Entity;


		public IQueryable<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> predicate) => Entity.Where(predicate);


		public T GetByID(int Id) => Entity.Single(e => e.ID == Id);

	}
}
