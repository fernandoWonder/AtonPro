
using System;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Interfaces.Repositories.ProductStock;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductStock
{
    public class StorageRepository : BaseRepository<Storage>, IStorageRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Storage.Where(c => c.FlagState && 
                    (c.Id.ToString().Contains(search) || c.Armazem.Contains(search)) )
                    select new { item.Id, item.Armazem, item.Descricao, item.DataCadastro }).ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Storage.Where(c => c.FlagState &&
                    (c.Id.ToString().Contains(search) || c.Armazem.Contains(search)))
                    select new { item.Id, item.Armazem, item.Descricao }).ToList();
        }
    }
}
