using Microsoft.EntityFrameworkCore;
using Wooza.Domain.Entities;
using Wooza.Infra.Data.Mapping;

namespace Wooza.Infra.Data.Context
{
    public class MySqlContext: DbContext
    {
		public DbSet<Plano> Plano { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
				optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Plano>(new PlanoMap().Configure);
		}
	}
}
