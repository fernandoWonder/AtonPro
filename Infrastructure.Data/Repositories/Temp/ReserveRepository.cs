using Domain.Domain.Entities.Temp;
using Domain.Domain.Interfaces.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Temp
{
    public class ReserveRepository : BaseRepository<Reserve>, IReserveTable
    {
        public object view1(string query)
        {
            var result = from reserve in _contextDB.Reserve.Where(p =>
                      (p.Data.Contains(query) || p.Cliente.Contains(query)))
                         select new
                         {
                             reserve.Id,
                             reserve.Cliente,
                             reserve.Data,
                             reserve.DataMarcada,
                             reserve.Hora,
                             reserve.Contacto,
                             reserve.Mesa.Mesa,
                             reserve.Observacoes,
                         };
            return result.ToList();
        }
    }
}
