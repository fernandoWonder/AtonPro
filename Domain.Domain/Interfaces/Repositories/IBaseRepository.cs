using System;
using System.Collections.Generic;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /*void insert(TEntity obj);
        void update(TEntity obj);
        void remove(TEntity obj);
        void removeForID(int id);*/

        int insert(TEntity obj);
        int update(TEntity obj);
        int remove(TEntity obj);
        int removeForID(int id);

        TEntity listForID(int id);
        List<TEntity> ListAll();
        // AsNoTracking Retorna os dados sem ladyLoad
        List<TEntity> ListAllAsNoTracking();

        void Dispose();
    }
}
