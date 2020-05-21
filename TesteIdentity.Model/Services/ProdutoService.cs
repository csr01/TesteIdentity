using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteIdentity.Model.Extensions;
using TesteIdentity.Model.Repository.Interfaces;
using TesteIdentity.Model.Services.Interfaces;

namespace TesteIdentity.Model.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnityOfWork _unity;

        public ProdutoService(IUnityOfWork unity)
        {
            _unity = unity;
        }
        public void AtualizaProduto(Produto produto)
        {
            var p = _unity.ProdutoRepository.BuscaPorId(produto.Id);

            p.Descricao = produto.Descricao;
            p.Marca = produto.Marca;
            p.Validade = produto.Validade;
            p.Valor = produto.Valor;

            _unity.ProdutoRepository.Atualiza(p);
            _unity.save();
        }

        public Produto BuscaPorId(long id)
        {
            return _unity.ProdutoRepository.BuscaPorId(id);
        }

        public IQueryable<Produto> BuscaProdutos(ProdutoFiltro filtro, Ordem ordem)
        {
            var listaProdutos = _unity.ProdutoRepository.BuscaTodos
                                    .ProdutosFiltro(filtro)
                                    .OrdenacaoProduto(ordem);
            return listaProdutos;
        }

        public void CriaProduto(Produto produto)
        {
            _unity.ProdutoRepository.Insere(produto);
            _unity.save();
        }

        public void RemoveProduto(Produto produto)
        {
            var p = _unity.ProdutoRepository.BuscaPorId(produto.Id);
            _unity.ProdutoRepository.Remove(p);
            _unity.save();
        }
    }
}
