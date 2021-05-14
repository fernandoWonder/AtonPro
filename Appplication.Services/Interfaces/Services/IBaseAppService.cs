using System.Collections.Generic;

namespace Appplication.Services.Interfaces.Services
{
    public interface IBaseAppService<TEntity> where TEntity : class
    {
        void insert(TEntity obj);
        void update(TEntity obj);
        void remove(TEntity obj);
        void removeForID(int id);
        TEntity listForID(int id);
        List<TEntity> ListAll();
        // AsNoTracking Retorna os dados sem ladyLoad
        List<TEntity> ListAllAsNoTracking();

        void Dispose();
    }
}
