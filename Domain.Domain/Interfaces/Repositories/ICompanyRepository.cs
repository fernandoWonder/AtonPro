using Domain.Domain.Entities;
using System;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface ICompanyRepository : IBaseRepository<Company>
    {
        Object view1(string search);
        Object view2(string search);
    }
}
