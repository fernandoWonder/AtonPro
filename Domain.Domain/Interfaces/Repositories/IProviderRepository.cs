using Domain.Domain.Entities;
using System;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface IProviderRepository : IBaseRepository<Provider>
    {
        object view1(string search);
        object view2(string search);
        object view3(string search);
    }
}
