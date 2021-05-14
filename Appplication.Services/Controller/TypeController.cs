using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public  class TypeController
    {
        TypeRespository _typeRepo = new TypeRespository();

        public List<Type> ListALL()
        {
            return _typeRepo.ListAll();
        }

        public List<Type> ListALLAsNoTracking()
        {
            return _typeRepo.ListAllAsNoTracking();
        }
        public Type getOne(int id)
        {
            return _typeRepo.listForID(id);
        }


        public int insert(Type bank)
        {
            return _typeRepo.insert(bank);
        }

        public int delete(Type bank)
        {
            return _typeRepo.remove(bank);
        }

        public int update(Type bank)
        {
            return _typeRepo.update(bank);
        }

        public int deleteFoId(int id)
        {
            return _typeRepo.removeForID(id);
        }
    }
}
