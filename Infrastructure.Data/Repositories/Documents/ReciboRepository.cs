using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class ReciboRepository : BaseRepository<Recibo>, IRecibo
    {
        public Recibo getForDocumentId(int documentId)
        {
            return _contextDB.Recibo.Where(c => c.DocumentoId == documentId).FirstOrDefault();
        }
    }
}
