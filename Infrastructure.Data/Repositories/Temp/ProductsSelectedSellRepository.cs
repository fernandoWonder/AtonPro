using System;
using Domain.Domain.Entities.Temp;
using Domain.Domain.Interfaces.Repositories.Temp;
using System.Linq;

namespace Infrastructure.Data.Repositories.Temp
{
    public class ProductsSelectedSellRepository : BaseRepository<ProductsSelectedSell>, IProductsSelectedSellRepository
    {
        public int Reset()
        {
            return _contextDB.Database.ExecuteSqlCommand("TRUNCATE TABLE [dbo].[ProductsSelectedSell]");
        }

        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.ProductsSelectedSell.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Produto.Descricao, item.Produto.Preco1, item.Quantidade, item.Desconto, Taxa = item.Produto.CodigoTaxa.Taxa, Total = ((item.Produto.Preco1 * item.Quantidade) - (item.Desconto * item.Produto.Preco1 / 100)) }).ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.ProductsSelectedSell.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Produto.Descricao, item.Produto.Preco1, item.Quantidade, item.Desconto, Total = ((item.Produto.Preco1 * item.Quantidade) - (item.Desconto * item.Produto.Preco1 / 100)) }).ToList();
        }
    }
}
