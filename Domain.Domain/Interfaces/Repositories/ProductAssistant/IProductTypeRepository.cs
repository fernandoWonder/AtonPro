using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface IProductTypeRepository : IBaseRepository<ProductType>
    {
        Object view1(string search);
    }
}
