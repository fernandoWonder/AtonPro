

using Domain.Domain.Entities.Financial;
using Domain.Domain.Interfaces.Repositories.Financial;

namespace Infrastructure.Data.Repositories.Financial
{
    public class BankRepository : BaseRepository<Bank> ,IBankRepository
    {

    }
}
