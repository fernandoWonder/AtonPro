using Domain.Domain.Entities.Assistants;
using System;

namespace Domain.Domain.Interfaces.Repositories.Assistants
{
    public interface ICityRepository : IBaseRepository<City>
    {
        object view1(string search);
        object view2(string search);
    }
}
