using Domain.Domain.Entities.ProductStock;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductStock
{
    public interface IStorageRepository : IBaseRepository<Storage>
    {
        object view1(string search);
        object view2(string search);
    }
}
