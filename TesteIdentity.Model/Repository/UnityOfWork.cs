using System;
using System.Collections.Generic;
using System.Text;
using TesteIdentity.Model.DataAcces;
using TesteIdentity.Model.Repository.Interfaces;

namespace TesteIdentity.Model.Repository
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly AppDbContext _contexto;
        private IProdutoRepository _produtoRepository;

        public UnityOfWork(AppDbContext context)
        {
            _contexto = context;
        }
        public IProdutoRepository ProdutoRepository  { get => _produtoRepository ?? new ProdutoRepository(_contexto); }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void save()
        {
            _contexto.SaveChanges();
        }
    }
}
