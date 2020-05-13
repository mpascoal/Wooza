using System;
using System.Collections.Generic;
using FluentValidation;
using Wooza.Domain.Entities;
using Wooza.Domain.Interfaces.Services;
using Wooze.Infra.Data.Repository;

namespace Wooza.Service.Services
{
    public class PlanoService : BaseService<Plano> , IPlanoService
    {
        private PlanoRepository repository = new PlanoRepository();

        public List<Plano> SearchByOperadora(string operadora)
        {
            if (operadora.Length > 0)
                throw new ArgumentException("Operadora não pode ser vazia.");

            return repository.SearchByCodigo(operadora);
        }

        public IList<Plano> SearchByTipo(string tipo)
        {
            if (tipo.Length > 0)
                throw new ArgumentException("Tipo não pode ser vazia.");

            return repository.SearchByTipo(tipo);
        }

        public IList<Plano> SearchByCodigo(string codigo)
        {
            if (codigo.Length > 0)
                throw new ArgumentException("Código não pode ser vazia.");

            return repository.SearchByCodigo(codigo);
        }
    }
}
