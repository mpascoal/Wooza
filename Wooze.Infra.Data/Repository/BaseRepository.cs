using System.Collections.Generic;
using System.Linq;
using Wooza.Domain.Entities;
using Wooza.Infra.Data.Context;

namespace Wooza.Infra.Data.Repository
{
    public class BaseRepository<T> where T : BaseEntity
    {
		private MySqlContext context = new MySqlContext();

		public void Insert(T obj)
		{
			context.Set<T>().Add(obj);
			context.SaveChanges();
		}

		public void Update(T obj)
		{
			context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}

		public void Remove(int id)
		{
			context.Set<T>().Remove(SelectById(id));
			context.SaveChanges();
		}

		public IList<T> SelectAll()
		{
			return context.Set<T>().ToList();
		}

		public T SelectById(int id)
		{
			return context.Set<T>().Find(id);
		}
	}
}
