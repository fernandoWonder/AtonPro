
using Domain.Domain.Entities.Financial;
using Infrastructure.Data.Repositories.Financial;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class BankController
    {
        BankRepository _bankRepo = new BankRepository();

        public List<Bank> ListALL()
        {
            return _bankRepo.ListAll();
        }

        public List<Bank> ListALLAsNoTracking()
        {
            return _bankRepo.ListAllAsNoTracking();
        }
        public Bank getOne(int id)
        {
            return _bankRepo.listForID(id);
        }


        public int insert(Bank bank)
        {
            return _bankRepo.insert(bank);
        }

        public int delete(Bank bank)
        {
            return _bankRepo.remove(bank);
        }

        public int update(Bank bank)
        {
            return _bankRepo.update(bank);
        }

        public int deleteFoId(int id)
        {
            return _bankRepo.removeForID(id);
        }

       /* public object view1(string search)
        {
            return _bankRepo.view1(search);
        }*/
    }
}
