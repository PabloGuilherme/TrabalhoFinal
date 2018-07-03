using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;

namespace Uniplac.Avaliacao.Testes.Base
{
    public static class ConstrutorObjeto
    {
        public static Funcionario CriarFuncionario()
        {
            return new Funcionario
            {
                Cargo = "Estagiario",
                CPF = "5198712322",
                DataNascimento = new DateTime(1990, 02, 19),
                Id = 1,
                Nome = "Pablo",
                Salario = 500
            };
        }

        public static Cliente CriarCliente()
        {
            return new Cliente
            {
                Nome = "Guilherme",
                CPF = "09823492888",
                DataNascimento = new DateTime(1997, 10, 19),
                Id = 1,
                
            };
        }

        public static Quarto CriarQuarto()
        {
            return new Quarto
            {
             Id = 1,
             Nome = "Basico",
             Valor = 50,
            
            };
        }
    }
}
