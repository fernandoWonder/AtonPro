using Domain.Domain.Entities.Financial;
using Infrastructure.Data.Repositories.Financial;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class CurrentAccountSystemController
    {
        CurrentAccountSystemRepository _currentAccountRepository = new CurrentAccountSystemRepository();

        public List<CurrentAccountSystem> ListALL()
        {
            return _currentAccountRepository.ListAll();
        }

        public List<CurrentAccountSystem> ListALLAsNoTracking()
        {
            return _currentAccountRepository.ListAllAsNoTracking();
        }
        public CurrentAccountSystem getOne(int id)
        {
            return _currentAccountRepository.listForID(id);
        }


        public int insert(CurrentAccountSystem currentAccount)
        {
            return _currentAccountRepository.insert(currentAccount);
        }

        public int delete(CurrentAccountSystem currentAccount)
        {
            return _currentAccountRepository.remove(currentAccount);
        }

        public int update(CurrentAccountSystem currentAccount)
        {
            return _currentAccountRepository.update(currentAccount);
        }

        public int deleteFoId(int id)
        {
            return _currentAccountRepository.removeForID(id);
        }

        /* public object view1(string search)
         {
             return _currentAccountRepository.view1(search);
         }*/
    }
}
