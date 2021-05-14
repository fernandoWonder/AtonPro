using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface ITaxCodeRepository : IBaseRepository<TaxCode>
    {
        object view1(string search);
        object motivosISE(string search);
    }
}
