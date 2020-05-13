using System;
using System.Collections.Generic;
using Wooza.Domain.Entities;

namespace Wooza.Domain.Interfaces.Services
{
    public interface IPlanoService : IService<Plano>
    {
        List<Plano> SearchByTipo(string tipo);
        List<Plano> SearchByOperadora(string operadora);
        List<Plano> SearchByCodigo(string codigo);
    }
}
