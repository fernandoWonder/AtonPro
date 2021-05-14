using Domain.Domain.Entities.Financial;
using Infrastructure.Data.Repositories.Financial;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class CurrentAccountMovmentsController
    {
        CurrentAccountMovmentsRepository _currentAccountMovmentsRepo = new CurrentAccountMovmentsRepository();

        public List<CurrentAccountMovments> ListALL()
        {
            return _currentAccountMovmentsRepo.ListAll();
        }

        public List<CurrentAccountMovments> ListALLAsNoTracking()
        {
            return _currentAccountMovmentsRepo.ListAllAsNoTracking();
        }
        public CurrentAccountMovments getOne(int id)
        {
            return _currentAccountMovmentsRepo.listForID(id);
        }

        public int insert(CurrentAccountMovments currentAccountMovments)
        {
            return _currentAccountMovmentsRepo.insert(currentAccountMovments);
        }

        public int delete(CurrentAccountMovments currentAccountMovments)
        {
            return _currentAccountMovmentsRepo.remove(currentAccountMovments);
        }

        public int update(CurrentAccountMovments currentAccountMovments)
        {
            return _currentAccountMovmentsRepo.update(currentAccountMovments);
        }

        public int deleteFoId(int id)
        {
            return _currentAccountMovmentsRepo.removeForID(id);
        }
    }
}
