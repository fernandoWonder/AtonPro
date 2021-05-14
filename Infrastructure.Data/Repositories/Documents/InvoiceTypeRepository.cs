using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class InvoiceTypeRepository : BaseRepository<InvoiceType>, IInvoiceTypeRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            var query = from dt in _contextDB.InvoiceType.Where(c => /*!c.FlagStandard &&*/ (c.Tipo.Contains(search) || c.Id.ToString().Contains(search))) select new { dt.Id, dt.Tipo, dt.Descricao };

            return query.ToList();
        }
    }
}
