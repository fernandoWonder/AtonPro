using Domain.Domain.Entities.Temp;
using System;

namespace Domain.Domain.Interfaces.Repositories.Temp
{
    public interface IProductsSelectedSellRepository : IBaseRepository<ProductsSelectedSell>
    {
        Object view1(string search);
        Object view2(string search);
        int Reset();
    }
}
