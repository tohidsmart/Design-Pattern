using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	class DbRepository<T>:IRepository<T> where T:class
	{
		 DbSet<T> DbSet;

		 public DbRepository(DbContext DbContext)
		 {
			 DbSet = DbContext.Set<T>();
		 }

		 public void Insert(T Entity)
		 {
			 DbSet.Add(Entity);
		 }

		 public void Delete(T Entity)
		 {
			 DbSet.Remove(Entity);
		 }

		 public IQueryable<T> GetAll()
		 {
			return DbSet;
		 }

		 public IQueryable<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> Predicate)
		 {
			 return DbSet.Where(Predicate);
		 }

		 public T GetByID(int ID)
		 {
			 return DbSet.Find(ID);
		 }
	}
}
