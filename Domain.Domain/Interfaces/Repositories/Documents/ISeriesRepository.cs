using Domain.Domain.Entities.Documents;
using System;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface ISeriesRepository : IBaseRepository<Series>
    {
        object view1(string search);
    }
}
