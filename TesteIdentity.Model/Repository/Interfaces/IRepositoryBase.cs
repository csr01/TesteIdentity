using System.Linq;

namespace TesteIdentity.Model.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class 
    {
        IQueryable<T> BuscaTodos { get; }

        T BuscaPorId(long id);
        void Insere(T objeto);
        void Atualiza(T objeto);
        void Remove(T obj);
    }
}