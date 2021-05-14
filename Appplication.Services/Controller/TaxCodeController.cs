using System.Collections.Generic;
using Infrastructure.Data.Repositories.ProductAssistant;
using Domain.Domain.Entities.ProductAssistant;

namespace Appplication.Controller
{
    public class TaxCodeController
    {
        TaxCodeRepository _taxRepository = new TaxCodeRepository();

        public List<TaxCode> ListALL()
        {
            return _taxRepository.ListAll();
        }

        public List<TaxCode> ListALLAsNoTracking()
        {
            return _taxRepository.ListAllAsNoTracking();
        }

        public int insert(TaxCode taxCode)
        {
            return _taxRepository.insert(taxCode);
        }

        public int delete(TaxCode taxCode)
        {
            return _taxRepository.remove(taxCode);
        }

        public int update(TaxCode taxCode)
        {
            return _taxRepository.update(taxCode);
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
