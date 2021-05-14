using Appplication.Services.Interfaces.Services;
using Domain.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Appplication.Services.Services
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public BaseAppService(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }
        public void Dispose()
        {
            _baseService.Dispose();
        }

        public void insert(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> ListAllAsNoTracking()
        {
            throw new NotImplementedException();
        }

        public TEntity listForID(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void removeForID(int id)
        {
            throw new NotImplementedException();
        }

        public void update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
