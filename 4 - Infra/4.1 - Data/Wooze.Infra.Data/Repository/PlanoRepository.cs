using System;
using System.Collections.Generic;
using System.Linq;
using Wooza.Domain.Entities;
using Wooza.Domain.Interfaces.Repositories;
using Wooza.Infra.Data.Context;
using Wooza.Infra.Data.Repository;

namespace Wooze.Infra.Data.Repository
{
    public class PlanoRepository : BaseRepository<Plano>, IPlanoRepository
    {
        private MySqlContext context = new MySqlContext();

        public List<Plano> SearchByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Plano> SearchByOperadora(string operadora)
        {
            return context.Plano.ToList().FindAll(x => x.Operadora.Contains(operadora));
        }

        public List<Plano> SearchByTipo(string tipo)
        {
            return context.Plano.ToList().FindAll(x => x.Tipo.ToString().Contains(tipo));
        }

        public List<Plano> SerchByCodigo(string codigo)
        {
            return context.Plano.ToList().FindAll(x => x.Codigo.Contains(codigo)); 
        }
    }
}
