using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;
using System;

namespace Appplication.Controller
{
    public class ReciboController
    {
        ReciboRepository _reciboRepo = new ReciboRepository();

        public List<Recibo> ListALL()
        {
            return _reciboRepo.ListAll();
        }

        public List<Recibo> ListALLAsNoTracking()
        {
            return _reciboRepo.ListAllAsNoTracking();
        }
        public Recibo getOne(int id)
        {
            return _reciboRepo.listForID(id);
        }

        public Recibo getForDocumentId(int documentId)
        {
            return _reciboRepo.getForDocumentId(documentId);
        }

        public int insert(Recibo recibo)
        {
            return _reciboRepo.insert(recibo);
        }

        public int delete(Recibo recibo)
        {
            return _reciboRepo.remove(recibo);
        }

        public int update(Recibo recibo)
        {
            return _reciboRepo.update(recibo);
        }

        public int deleteFoId(int id)
        {
            return _reciboRepo.removeForID(id);
        }

        public void dispose()
        {
            _reciboRepo.Dispose();
        }
    }
}
