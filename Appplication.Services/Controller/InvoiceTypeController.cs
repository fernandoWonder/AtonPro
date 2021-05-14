using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;
namespace Appplication.Controller
{
    public class InvoiceTypeController
    {
        InvoiceTypeRepository _invoiceTypeRepo = new InvoiceTypeRepository();

        public List<InvoiceType> ListALL()
        {
            return _invoiceTypeRepo.ListAll();
        }

        public List<InvoiceType> ListALLAsNoTracking()
        {
            return _invoiceTypeRepo.ListAllAsNoTracking();
        }
        public InvoiceType getOne(string id)
        {
            return _invoiceTypeRepo.listForID(id);
        }


        public int insert(InvoiceType invoiceType)
        {
            return _invoiceTypeRepo.insert(invoiceType);
        }

        public int delete(InvoiceType invoiceType)
        {
            return _invoiceTypeRepo.remove(invoiceType);
        }

        public int update(InvoiceType invoiceType)
        {
            return _invoiceTypeRepo.update(invoiceType);
        }

        public int deleteFoId(int id)
        {
            return _invoiceTypeRepo.removeForID(id);
        }

        public object view1(string search)
        {
            return _invoiceTypeRepo.view1(search);
        }

    }
}
