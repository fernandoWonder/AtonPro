using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface ICompositionRepository : IBaseRepository<Composition>
    {
        Object view1(string search);
    }
}
