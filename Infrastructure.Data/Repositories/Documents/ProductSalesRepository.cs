using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class ProductSalesRepository : BaseRepository<ProductSales>, IProductSalesRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();

            return (from p in _contextDB.ProductSales.Where(c => c.Id.ToString().Contains(search) || c.Descricao_Produto.Contains(search) 
                    || c.DataCadastro.ToString().Contains(search) || c.FaturaId.ToString().Contains(search))
                    select new { p.Id, p.Descricao_Produto, p.Preco, p.Quantidade, p.Total,  p.FaturaId, p.Observacao} ).ToList();
        }

        public object view2(string search)
        {
            throw new NotImplementedException();
        }
    }
}
