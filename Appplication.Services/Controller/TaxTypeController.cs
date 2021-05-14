using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class TaxTypeController
    {
        TaxTypeRepository _taxRepository = new TaxTypeRepository();

        public List<TaxType> ListALL()
        {
            return _taxRepository.ListAll();
        }

        public List<TaxType> ListALLAsNoTracking()
        {
            return _taxRepository.ListAllAsNoTracking();
        }
        public TaxType getOne(int id)
        {
            return _taxRepository.listForID(id);
        }

        public int insert(TaxType taxType)
        {
            return _taxRepository.insert(taxType);
        }

        public int delete(TaxType taxType)
        {
            return _taxRepository.remove(taxType);
        }

        public int update(TaxType taxType)
        {
            return _taxRepository.update(taxType);
        }

        public int deleteFoId(int id)
        {
            return _taxRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _taxRepository.view1(search);
        }
    }
}
