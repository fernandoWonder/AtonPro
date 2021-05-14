using Domain.Domain.Entities.Documents;
using System;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IInvoiceTypeRepository : IBaseRepository<InvoiceType>
    {
        Object view1(string search);
    }
}
