using System;
using System.Collections.Generic;
using System.Text;
using TesteIdentity.Model.DataAcces;
using TesteIdentity.Model.Repository.Interfaces;

namespace TesteIdentity.Model.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>,IProdutoRepository
    {
        public ProdutoRepository(AppDbContext contexto) : base(contexto)
        {
        }
    }
}
