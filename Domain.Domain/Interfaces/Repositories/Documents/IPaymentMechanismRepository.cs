using Domain.Domain.Entities.Documents;
using System;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
    public interface IPaymentMechanismRepository : IBaseRepository<PaymentMechanism>
    {
        object view1(string search);
    }
}
