using Domain.Domain.Interfaces.Repositories;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected ContextDB _contextDB;
        
        public BaseRepository()
        {
            _contextDB = new ContextDB();
        }
        public void Dispose()
        {
           
            _contextDB.Dispose();
        }

        private int Save()
        {
            return _contextDB.SaveChanges();
        }

        public int insert(TEntity obj)
        {
            _contextDB.Set<TEntity>().Add(obj);
            return Save(); // Obs: Tirar depois todos saveChanges daqui para trabalhar com UnitOfWork
        }

        public List<TEntity> ListAll()
        {
            return _contextDB.Set<TEntity>().ToList();
        }

        public List<TEntity> ListAllAsNoTracking()
        {
            return _contextDB.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity listForID(int id)
        {
            return _contextDB.Set<TEntity>().Find(id);
        }

        public TEntity listForID(string id)
        {
            return _contextDB.Set<TEntity>().Find(id);
        }

        public TEntity getLast()
        {
            return _contextDB.Set<TEntity>().ToList().LastOrDefault();
        }

        public int remove(TEntity obj)
        {
            _contextDB.Set<TEntity>().Remove(obj);
            return Save();
        }

        public int removeForID(int id)
        {
            var obj = listForID(id);
            remove(obj);
            return Save();
        }

        public int removeForID(string id)
        {
            var obj = listForID(id);
            remove(obj);
            return Save();
        }
        public int update(TEntity obj)
        {

            _contextDB.Entry(obj).State = EntityState.Modified;
            return Save();
        }
    }
}
