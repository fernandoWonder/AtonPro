using Domain.Domain.Entities.Temp;
using Domain.Domain.Interfaces.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Temp
{
    public class ProductsSelectedTableRepository : BaseRepository<ProductSellectedTable>, IProductsSelectedTableRepository
    {
        public object view1(string query)
        {
            throw new NotImplementedException();
        }

        public List<ProductSellectedTable> view1(string search,int idMesa)
        {
            search = search.ToLower();
           // List<dynamic> listagem = new List<dynamic>();
            List<ProductSellectedTable> lista = new List<ProductSellectedTable>();
            foreach (var item in (from item in _contextDB.ProductSellectedTable.Where(c => c.MesaId == idMesa) select new { item.Id, item.Mesa, item.MesaId, item.Preco, item.productoName, item.Produto.Descricao,item.Produto, item.ProdutoId, item.Quantidade, item.Stock, item.StockId }).ToList())
            {
               // lista.Add(new BaseUnitController());
                lista.Add(new ProductSellectedTable() {
                     Id = item.Id,
                     MesaId = item.MesaId,
                     Preco = item.Preco,
                     Quantidade = item.Quantidade,
                     StockId= item.StockId,
                     ProdutoId = item.ProdutoId,
                     productoName = item.Descricao,
                     
                });
            }
            return lista;  
        }

    }
}
