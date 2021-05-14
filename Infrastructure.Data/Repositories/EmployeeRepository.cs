using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;

namespace Infrastructure.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public object view1(string search)
        {
            throw new NotImplementedException();
        }

        public object view2(string search)
        {
            throw new NotImplementedException();
        }
    }
}
