using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class ProductTypeRepository : BaseRepository<ProductType>, IProductTypeRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.ProductType.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Tipo, item.Descricao, item.DataCadastro }).ToList();
        }
    }
}
