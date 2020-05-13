using System.Collections.Generic;
using Wooza.Domain.Entities;

namespace Wooza.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T SelectById(int id);

        IList<T> SelectAll();
    }
}
