using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic.Core;

namespace TesteIdentity.Model.Extensions
{
    public static class ProdutoExtension
    { 
        public static IQueryable<Produto> ProdutosFiltro(this IQueryable<Produto> query, ProdutoFiltro filtro)
        {
            if(filtro != null)
            {
                if (!string.IsNullOrEmpty(filtro.Descricao))
                {
                    query = query.Where(p => p.Descricao.Contains(filtro.Descricao));
                }

                if (!string.IsNullOrEmpty(filtro.Marca))
                {
                    query = query.Where(p => p.Marca.Equals(filtro.Marca));
                }
            }

            return query;
        }
        
        public static IQueryable<Produto> OrdenacaoProduto(this IQueryable<Produto> query, Ordem ordenacao)
        {
            if(!string.IsNullOrEmpty(ordenacao.OrdenaPor))
            {
                query = query.OrderBy(ordenacao.OrdenaPor);
            }

            return query;
        }
    }

    public class Ordem
    {
        public string OrdenaPor { get; set; }
    }

    public class ProdutoFiltro
    {
        public string Marca { get; set; }
        public string Descricao { get; set; }
    }
}
