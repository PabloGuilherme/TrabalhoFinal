using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Funcionario
    {
        public Cliente Cliente { get; set; }
        public string Cargo { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Id { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public void Validar()
        {
            if (String.IsNullOrWhiteSpace(Nome))
                throw new DominioException("Primeiro nome inválido!");
            if (String.IsNullOrWhiteSpace(CPF))
                throw new DominioException("CPF inválido!");
            if (String.IsNullOrWhiteSpace(Cargo))
                throw new DominioException("Cargo inválido!");
            if (Salario <= 0)
            {
                throw new DominioException("Salario inválido!");
            }
            if (Cliente == null)
            {
                throw new DominioException("Cliente inválido!");
            }

            if (DataNascimento == new DateTime(0001, 01, 01))
                throw new DominioException("Data nascimento inválida!");
           
        }
    }
}
