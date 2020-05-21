using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteIdentity.Model.DataAcces;
using TesteIdentity.Model.Repository.Interfaces;

namespace TesteIdentity.Model.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _contexto;
        public RepositoryBase(AppDbContext contexto)
        {
            _contexto = contexto;
        }
        public IQueryable<T> BuscaTodos => _contexto.Set<T>().AsQueryable();

        public void Atualiza(T objeto)
        {
            _contexto.Set<T>().Update(objeto);
        }

        public T BuscaPorId(long id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public void Insere(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
        }

        public void Remove(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
        }
    }
}
