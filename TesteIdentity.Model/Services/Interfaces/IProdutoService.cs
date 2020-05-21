using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteIdentity.Model.Extensions;

namespace TesteIdentity.Model.Services.Interfaces
{
    public interface IProdutoService
    {
        IQueryable<Produto> BuscaProdutos(ProdutoFiltro filtro, Ordem ordem);

        Produto BuscaPorId(long id);
        void CriaProduto(Produto produto);
        void AtualizaProduto(Produto produto);
        void RemoveProduto(Produto produto);
    }
}
