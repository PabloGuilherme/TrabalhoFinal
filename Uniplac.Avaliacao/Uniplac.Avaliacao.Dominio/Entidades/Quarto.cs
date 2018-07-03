using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Quarto
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

        public void Validar()
        {
            if (String.IsNullOrWhiteSpace(Nome))
                throw new DominioException("Primeiro nome inválido!");
  
         
            if (Valor <= 0)
            {
                throw new DominioException("Valor inválido!");
            }

            

        }
    }
}

