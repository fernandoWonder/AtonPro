using Domain.Domain.Entities.Temp;
using Infrastructure.Data.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class TurnoController
    {
        TurnoRepository _TurnoController = new TurnoRepository();

        public List<Turno> ListALL()
        {
            return _TurnoController.ListAll();
        }
        public Turno listForId(int id)
        {
            return _TurnoController.listForID(id);
        }
        public object view1(string s)
        {
            return _TurnoController.view1(s);
        }
        

        public List<Turno> ListALLAsNoTracking()
        {
            return _TurnoController.ListAllAsNoTracking();
        }
        public Turno getOne(int id)
        {
            return _TurnoController.listForID(id);
        }
        public Turno getLast()
        {
            return _TurnoController.getLast();
        }


        public int insert(Turno Turno)
        {
            return _TurnoController.insert(Turno);
        }

        public int delete(Turno Turno)
        {
            return _TurnoController.remove(Turno);
        }

        public int update(Turno Turno)
        {
            return _TurnoController.update(Turno);
        }

        public int removeForId(int id)
        {
            return _TurnoController.removeForID(id);
        }
    }
}
