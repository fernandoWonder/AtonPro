using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class PaymentsRecibosController
    {
        PaymentsRecibosRepository _paymentsRecibosRepo = new PaymentsRecibosRepository();

        public List<PaymentsRecibos> ListALL()
        {
            return _paymentsRecibosRepo.ListAll();
        }

        public List<PaymentsRecibos> ListALLAsNoTracking()
        {
            return _paymentsRecibosRepo.ListAllAsNoTracking();
        }
        public PaymentsRecibos getOne(int id)
        {
            return _paymentsRecibosRepo.listForID(id);
        }


        public int insert(PaymentsRecibos paymentsRecibos)
        {
            return _paymentsRecibosRepo.insert(paymentsRecibos);
        }

        public int delete(PaymentsRecibos paymentsRecibos)
        {
            return _paymentsRecibosRepo.remove(paymentsRecibos);
        }

        public int update(PaymentsRecibos paymentsRecibos)
        {
            return _paymentsRecibosRepo.update(paymentsRecibos);
        }

        public int deleteFoId(int id)
        {
            return _paymentsRecibosRepo.removeForID(id);
        }
    }
}
