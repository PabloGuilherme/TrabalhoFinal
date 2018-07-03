using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Contratos;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;

namespace Uniplac.Avaliacao.Infra.Dados.Repositorios
{
    public class QuartoRepositorio : IQuartoRepositorio
    {
        public AvaliacaoContexto _contexto;

        public QuartoRepositorio()
        {
            _contexto = new AvaliacaoContexto();
        }

        public void Adicionar(Quarto entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Quartos.Attach(entidade);
            }

            _contexto.Quartos.Add(entidade);

            _contexto.SaveChanges();
        }

        public Quarto BuscarPor(int id)
        {
            return _contexto.Quartos.Find(id);
        }

        public Quarto BuscarPorNome(string nome)
        {
            return _contexto.Quartos
                .Where(p => p.Nome == nome)
                .FirstOrDefault();
        }

        public List<Quarto> BuscarTudo()
        {
            return _contexto.Quartos.ToList();
        }

        public void Deletar(Quarto entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Quartos.Attach(entidade);
            }

            _contexto.Quartos.Remove(entidade);

            _contexto.SaveChanges();
        }

        public void Editar(Quarto entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Quartos.Attach(entidade);
            }

            _contexto.SaveChanges();
        }
    }
}

