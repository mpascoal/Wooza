using System.Collections.Generic;
using Wooza.Domain.Entities;
namespace Wooza.Domain.Interfaces.Repositories
{

    public interface IPlanoRepository : IRepository<Plano>
    {
        IList<Plano> SearchByTipo(string tipo);
        IList<Plano> SearchByOperadora(string operadora);
        IList<Plano> SearchByCodigo(string codigo);
    }

}