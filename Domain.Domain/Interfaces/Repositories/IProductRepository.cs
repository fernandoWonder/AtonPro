using Domain.Domain.Entities;
using System;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Object view1(string search);
        Object view2(string search);
    }
}
