using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class PaymentMechanismRepository : BaseRepository<PaymentMechanism>, IPaymentMechanismRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            var query = from p in _contextDB.PaymentMechanism.Where(c => c.Id.ToString().Contains(search) || c.Descricao.Contains(search) )
                        select new { p.Id, p.Descricao };

            return query.ToList();
        }
    }
}
