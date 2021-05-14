using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;

namespace Infrastructure.Data.Repositories
{
    public class SystemInfoRepository : BaseRepository<SystemInfo>, ISystemInfoRepository
    {
    }
}
