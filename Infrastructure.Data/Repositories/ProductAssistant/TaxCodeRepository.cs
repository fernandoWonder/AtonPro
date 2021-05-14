using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class TaxCodeRepository : BaseRepository<TaxCode>, ITaxCodeRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.TaxCode.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Code, item.Descricao }).ToList();
        }

        public object motivosISE(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.TaxReasonExemption.Where(c => c.Id.ToString().Contains(search) || c.Id.Contains(search) )
                    select new { item.Id, item.MencaoFatura,}).ToList();
        }
    }
}
