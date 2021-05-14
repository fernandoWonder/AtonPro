using Domain.Domain.Entities.Financial;
using Domain.Domain.Interfaces.Repositories.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Financial
{
    public class CurrentAccountSystemRepository : BaseRepository<CurrentAccountSystem>, ICurrentAccountSystemRepository
    {
    }
}
