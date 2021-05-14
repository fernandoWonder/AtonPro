using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface ITaxTypeRepository : IBaseRepository<TaxType>
    {
        Object view1(string search);
    }
}
