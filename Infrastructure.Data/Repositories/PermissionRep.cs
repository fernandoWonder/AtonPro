using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PermissionRep : BaseRepository<Permission> , IRemission
    {
        public Permission getForIdUser(int idUser)
        {
            return _contextDB.Permission.Where(c => c.UsuarioId == idUser).FirstOrDefault();
        }
    }
}
