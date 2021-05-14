
using Domain.Domain.Interfaces.Repositories;

namespace Domain.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
    }
}
