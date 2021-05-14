using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IInvoiceStatus : IBaseRepository<InvoiceStatus>
    {
        object view(string search);
    }
}
