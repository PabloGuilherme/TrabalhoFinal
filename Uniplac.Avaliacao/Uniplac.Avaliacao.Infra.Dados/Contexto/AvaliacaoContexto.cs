using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;

namespace Uniplac.Avaliacao.Infra.Dados.Contexto
{
    public class AvaliacaoContexto : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Quarto> Quartos { get; set; }

        public AvaliacaoContexto() : base("Pablo_AvaliacaoDB")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Funcionario>()
            //   .ToTable("TBFuncionario");

            //modelBuilder.Entity<Cliente>()
            //   .ToTable("TBCliente");

            //modelBuilder.Entity<Quarto>()
            //   .ToTable("TBQuarto");
        }
    }

}
