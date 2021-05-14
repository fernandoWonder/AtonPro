using Domain.Domain.Entities.Temp;
using Infrastructure.Data.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ReserveController
    {
        ReserveRepository reserveRepository = new ReserveRepository();
        public ReserveController()
        {
             
          
        }

        public int insert(Reserve reserve)
        {
            return reserveRepository.insert(reserve);
        }
        public List<Reserve> ListAll()
        {
            return reserveRepository.ListAll();
        }
        public List<Reserve> ListAllAsNoTracking()
        {
            return reserveRepository.ListAllAsNoTracking();
        }
        public Reserve listForId(int id)
        {
            return reserveRepository.listForID(id);
        }
        public int remove(Reserve reserve)
        {
            return reserveRepository.remove(reserve);
        }
        public int removeForId(int id)
        {
            return reserveRepository.removeForID(id);
        }
        public int update(Reserve reserve)
        {
            return reserveRepository.update(reserve);
        }
        public object view1(string query)
        {
            return reserveRepository.view1(query);
        }
    }
}
