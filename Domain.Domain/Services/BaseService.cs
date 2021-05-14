using Domain.Domain.Interfaces.Repositories;
using Domain.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Services
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public void Dispose()
        {
            _baseRepository.Dispose();
        }

        public void insert(TEntity obj)
        {
            _baseRepository.insert(obj);
        }

        public List<TEntity> ListAll()
        {
            return _baseRepository.ListAll();
        }

        public List<TEntity> ListAllAsNoTracking()
        {
            return _baseRepository.ListAllAsNoTracking();
        }

        public TEntity listForID(int id)
        {
            return _baseRepository.listForID(id);
        }

        public void remove(TEntity obj)
        {
            _baseRepository.remove(obj);
        }

        public void removeForID(int id)
        {
            _baseRepository.removeForID(id);
        }

        public void update(TEntity obj)
        {
            _baseRepository.update(obj);
        }
    }
}
