using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class BaseUnitController
    {
        BaseUnitRepository _baseUnitRepository = new BaseUnitRepository();

        public List<BaseUnit> ListALL()
        {
            return _baseUnitRepository.ListAll();
        }

        public List<BaseUnit> ListALLAsNoTracking()
        {
            return _baseUnitRepository.ListAllAsNoTracking();
        }

        public int insert(BaseUnit baseUnit)
        {
            return _baseUnitRepository.insert(baseUnit);
        }

        public int delete(BaseUnit baseUnit)
        {
            return _baseUnitRepository.remove(baseUnit);
        }

        public int update(BaseUnit baseUnit)
        {
            return _baseUnitRepository.update(baseUnit);
        }

        public int deleteFoId(int id)
        {
            return _baseUnitRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _baseUnitRepository.view1(search);
        }

    }
}
