using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface IBaseUnitRepository : IBaseRepository<BaseUnit>
    {
        Object view1(string search);
    }
}
