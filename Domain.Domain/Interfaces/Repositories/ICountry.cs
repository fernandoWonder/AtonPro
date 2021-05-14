using Domain.Domain.Entities;
using System;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        object view1(string search);
        object view2(string search);
    }
}
