using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class InvoiceNoteReasonController
    {
        InvoiceNoteReasonRepository _InvoiceNoteReasonRepository = new InvoiceNoteReasonRepository();

        public List<InvoiceNoteReason> ListALL()
        {
            return _InvoiceNoteReasonRepository.ListAll();
        }

        public List<InvoiceNoteReason> ListALLAsNoTracking()
        {
            return _InvoiceNoteReasonRepository.ListAllAsNoTracking();
        }
        public InvoiceNoteReason getOne(int id)
        {
            return _InvoiceNoteReasonRepository.listForID(id);
        }
        public int insert(InvoiceNoteReason invoiceNoteReason)
        {
            return _InvoiceNoteReasonRepository.insert(invoiceNoteReason);
        }

        public int delete(InvoiceNoteReason invoiceNoteReason)
        {
            return _InvoiceNoteReasonRepository.remove(invoiceNoteReason);
        }

        public int update(InvoiceNoteReason invoiceNoteReason)
        {
            return _InvoiceNoteReasonRepository.update(invoiceNoteReason);
        }

        public int deleteFoId(int id)
        {
            return _InvoiceNoteReasonRepository.removeForID(id);
        }

    }
}
