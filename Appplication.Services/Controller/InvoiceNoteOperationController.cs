using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class InvoiceNoteOperationController
    {
        InvoiceNoteOperationTypeRepository _InvoiceNoteOpTypeRepository = new InvoiceNoteOperationTypeRepository();

        public List<InvoiceNoteOperationType> ListALL()
        {
            return _InvoiceNoteOpTypeRepository.ListAll();
        }

        public List<InvoiceNoteOperationType> ListALLAsNoTracking()
        {
            return _InvoiceNoteOpTypeRepository.ListAllAsNoTracking();
        }
        public InvoiceNoteOperationType getOne(int id)
        {
            return _InvoiceNoteOpTypeRepository.listForID(id);
        }
        public int insert(InvoiceNoteOperationType invoiceNoteOperationType)
        {
            return _InvoiceNoteOpTypeRepository.insert(invoiceNoteOperationType);
        }

        public int delete(InvoiceNoteOperationType invoiceNoteOperationType)
        {
            return _InvoiceNoteOpTypeRepository.remove(invoiceNoteOperationType);
        }

        public int update(InvoiceNoteOperationType invoiceNoteOperationType)
        {
            return _InvoiceNoteOpTypeRepository.update(invoiceNoteOperationType);
        }

        public int deleteFoId(int id)
        {
            return _InvoiceNoteOpTypeRepository.removeForID(id);
        }
    }
}
