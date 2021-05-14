using Domain.Domain.Entities.Temp;
using Domain.Domain.Interfaces.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Temp
{
    public class TurnoRepository: BaseRepository<Turno> , ITurno
    {
        public object view1(string s)
        {
            return (from per in _contextDB.Turno.Where(c=>c.Id.ToString().Contains(s)) select new { per.Id, per.Estado, per.Data, per.Caixa, per.Abertura, per.Hora, per.Tpa, per.User.Nome, per.UserId }).ToList();
        }
    }
}
