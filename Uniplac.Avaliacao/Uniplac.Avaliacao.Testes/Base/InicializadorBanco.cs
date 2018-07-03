using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;

namespace Uniplac.Avaliacao.Testes.Base
{
    public class InicializadorBanco <T> : DropCreateDatabaseAlways<AvaliacaoContexto>
    {
        protected override void Seed(AvaliacaoContexto context)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cargo = "Estagiario";
            funcionario.CPF = "5198712322";
            funcionario.DataNascimento = DateTime.Now.AddYears(-28);
            funcionario.Id = 1;
            funcionario.Nome = "Pablo";
            funcionario.Salario = 500;
            
            context.Funcionarios.Add(funcionario);

            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "09823492888";
            cliente.DataNascimento = DateTime.Now.AddYears(-21);
            cliente.Id = 1;
            

            context.Clientes.Add(cliente);

            Quarto quarto = new Quarto();
            quarto.Id = 1;
            quarto.Nome = "Basico";
            quarto.Valor = 50;
            


            context.Quartos.Add(quarto);

            base.Seed(context);

        }
       
     
    }
}
