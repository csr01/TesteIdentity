using System;
using System.Linq;

namespace TesteIdentity.Repository
{
    public class RepositoryBase<T> where T : class
    {
        private readonly 
        public IQueryable<T> ListaProdutos { get; }
        public T BuscaProduto(long id)
        {

        }
    }
}
