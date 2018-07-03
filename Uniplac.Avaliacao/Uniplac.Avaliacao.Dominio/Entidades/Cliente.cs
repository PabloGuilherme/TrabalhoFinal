using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Cliente
    {

        
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Id { get; set; }

        public string Nome { get; set; }

        

        public void Validar()
        {
            if (String.IsNullOrWhiteSpace(Nome))
                throw new DominioException("Primeiro nome inválido!");
            if (String.IsNullOrWhiteSpace(CPF))
                throw new DominioException("CPF inválido!");

            if (DataNascimento == new DateTime(0001, 01, 01))
                throw new DominioException("Data nascimento inválida!");
            


        }
    }
}
