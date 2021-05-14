using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface ICompositionProductsRepository : IBaseRepository<CompositionProducts>
    {
        Object view1(string search);
        Object view2(string search);
    }
}
