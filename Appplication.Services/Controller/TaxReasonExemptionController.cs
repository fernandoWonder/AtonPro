using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class TaxReasonExemptionController
    {
        TaxReasonExemptionRepository _taxRepository = new TaxReasonExemptionRepository();

        public List<TaxReasonExemption> ListALL()
        {
            return _taxRepository.ListAll();
        }

        public List<TaxReasonExemption> ListALLAsNoTracking()
        {
            return _taxRepository.ListAllAsNoTracking();
        }
        public TaxReasonExemption getOne(string id)
        {
            return _taxRepository.listForID(id);
        }
        public int insert(TaxReasonExemption taxReasonExemption)
        {
            return _taxRepository.insert(taxReasonExemption);
        }

        public int delete(TaxReasonExemption taxReasonExemption)
        {
            return _taxRepository.remove(taxReasonExemption);
        }

        public int update(TaxReasonExemption taxReasonExemption)
        {
            return _taxRepository.update(taxReasonExemption);
        }

        public int deleteFoId(int id)
        {
            return _taxRepository.removeForID(id);
        }

        public int deleteFoId(string id)
        {
            return _taxRepository.removeForID(id);
        }

        public void Dispose()
        {
            _taxRepository.Dispose();
        }
    }
}
