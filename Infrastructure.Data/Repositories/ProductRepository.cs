using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public int removeProduct(Product product)
        {
            product.FlagState = false;
            return update(product);
        }

        public object view1(string search)
        {
            var result = from prod in _contextDB.Product.Where(p => p.FlagState && 
                         (p.Descricao.Contains(search) || p.Codigo_Barra.Contains(search) || p.Codigo.Contains(search)) )
                         select new {
                             prod.Id,
                             prod.Codigo_Barra,
                             prod.Descricao,
                             prod.Categoria.Categoria,
                             prod.Preco1,
                             prod.Preco2,
                             prod.Preco3,
                             prod.UnidadeBase.Unidade,
                             prod.CodigoTaxa.Taxa,
                             Isenta = prod.MotivoISE.MencaoFatura,
                             Tipo_Artigo = prod.TipoArtigo.Descricao,
                             prod.DataExpiracao};
            return result.ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            var result = from prod in _contextDB.Product.Where(p => p.FlagState && ( p.Descricao.Contains(search) || 
                         p.Codigo_Barra.Contains(search) || p.Codigo.Contains(search)) )
                         select new {
                             prod.Id,
                             prod.Codigo_Barra,
                             prod.Descricao,
                             prod.Categoria.Categoria,
                             prod.Preco1,
                             prod.UnidadeBase.Unidade,
                             prod.CodigoTaxa.Taxa,
                             Isenta = prod.MotivoISE.MencaoFatura,
                             Tipo_Artigo = prod.TipoArtigo.Descricao
                         };
            return result.ToList();
        }

        public object view3(string search)
        {
            search = search.ToLower();
            var result = from prod in _contextDB.Product.Where(p => p.FlagState && (p.Descricao.Contains(search) ||
                         p.Codigo_Barra.Contains(search) || p.Codigo.Contains(search)))
                         select new { prod.Id, prod.Codigo, prod.Codigo_Barra, prod.Descricao, prod.Categoria };
            return result.ToList();
        }

        public Product getForCodigoBarra(string codigoBarra)
        {
            return _contextDB.Product.Where(c => c.Codigo_Barra.Equals(codigoBarra)).FirstOrDefault();
        }

        public Product getForCodigoProduto(string codigoProduto)
        {
            return _contextDB.Product.Where(c => c.Codigo.Equals(codigoProduto)).FirstOrDefault();
        }

    }
}
