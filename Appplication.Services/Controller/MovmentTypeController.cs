using Domain.Domain.Entities.Financial;
using Infrastructure.Data.Repositories.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class MovmentTypeController
    {
        MovmentTypeRepository _movmentTypeRepo = new MovmentTypeRepository();

        public List<MovmentType> ListALL()
        {
            return _movmentTypeRepo.ListAll();
        }

        public List<MovmentType> ListALLAsNoTracking()
        {
            return _movmentTypeRepo.ListAllAsNoTracking();
        }
        public MovmentType getOne(int id)
        {
            return _movmentTypeRepo.listForID(id);
        }

        public int insert(MovmentType movmentType)
        {
            return _movmentTypeRepo.insert(movmentType);
        }

        public int delete(MovmentType movmentType)
        {
            return _movmentTypeRepo.remove(movmentType);
        }

        public int update(MovmentType movmentType)
        {
            return _movmentTypeRepo.update(movmentType);
        }

        public int deleteFoId(int id)
        {
            return _movmentTypeRepo.removeForID(id);
        }
    }
}
