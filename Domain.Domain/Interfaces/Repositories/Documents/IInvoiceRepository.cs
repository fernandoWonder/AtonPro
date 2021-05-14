using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        object view1(string search);
        List<int> view2(string search);
        List<int> view3(string search,DateTime date1,DateTime date2);
        List<ProductSales> productsInvoice(int idInvoice);
    }
}
