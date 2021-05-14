using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    class InvoiceStatusRepository : BaseRepository<InvoiceStatus>, IInvoiceStatus
    {
        public object view(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.InvoiceStatus.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Estado, item.Descricao }).ToList();
        }
    }
}
