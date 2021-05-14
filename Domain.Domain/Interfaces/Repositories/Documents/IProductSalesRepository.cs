using Domain.Domain.Entities.Documents;
using System;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IProductSalesRepository : IBaseRepository<ProductSales>
    {
        object view1(string search);
        object view2(string search);
    }
}
