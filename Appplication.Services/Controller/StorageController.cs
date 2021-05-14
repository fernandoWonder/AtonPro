using Domain.Domain.Entities.ProductStock;
using Infrastructure.Data.Repositories.ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class StorageController
    {
        StorageRepository _storageRepository = new StorageRepository();

        public int inserir(Storage st)
        {
            return _storageRepository.insert(st);
        }

        public int deleteForId(int id)
        {
            return _storageRepository.removeForID(id);
        }

        public int update(Storage st)
        {
            return _storageRepository.update(st);
        }
        public int delete(Storage st)
        {
            return _storageRepository.remove(st);
        }
        public Storage getOne(int id)
        {
            return _storageRepository.listForID(id);
        }
        public List<Storage> List()
        {
            return _storageRepository.ListAllAsNoTracking();
        }

        public object view1(string search)
        {
            return _storageRepository.view1(search);
        }

        public object view2(string search)
        {
            return _storageRepository.view2(search);
        }
    }
}
