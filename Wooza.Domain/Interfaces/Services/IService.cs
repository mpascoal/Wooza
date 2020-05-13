using System.Collections.Generic;
using FluentValidation;
using Wooza.Domain.Entities;

namespace Wooza.Domain.Interfaces.Services
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
