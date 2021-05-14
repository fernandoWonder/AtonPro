using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class PaymentMechanismController
    {
        PaymentMechanismRepository _paymentMechanismRep = new PaymentMechanismRepository();

        public List<PaymentMechanism> ListALL()
        {
            return _paymentMechanismRep.ListAll();
        }

        public List<PaymentMechanism> ListALLAsNoTracking()
        {
            return _paymentMechanismRep.ListAllAsNoTracking();
        }

        public PaymentMechanism getOne(string id)
        {
            return _paymentMechanismRep.listForID(id);
        }

        public int insert(PaymentMechanism paymentMechanism)
        {
            return _paymentMechanismRep.insert(paymentMechanism);
        }

        public int delete(PaymentMechanism paymentMechanism)
        {
            return _paymentMechanismRep.remove(paymentMechanism);
        }

        public int update(PaymentMechanism paymentMechanism)
        {
            return _paymentMechanismRep.update(paymentMechanism);
        }

        public int deleteFoId(int id)
        {
            return _paymentMechanismRep.removeForID(id);
        }

        public object view1(string search)
        {
            return _paymentMechanismRep.view1(search);
        }

    }
}
