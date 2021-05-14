using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class TaxTypeRepository : BaseRepository<TaxType>, ITaxTypeRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.TaxType.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Tipo, item.Descricao }).ToList();
        }
    }
}
