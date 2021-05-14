using Domain.Domain.Entities.ProductAssistant;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductAssistant
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Object view1(string search);
    }
}
