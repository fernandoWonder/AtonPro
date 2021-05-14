using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IProductEntryRepository : IBaseRepository<ProductEntry>
    {
        List<int> view1(string search);
        object view2(string search);
        List<int> view3(string search,DateTime date1, DateTime date2);
    }
}
