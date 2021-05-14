using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class PrinterController
    {

        PrinterRep _bankRepo = new PrinterRep();

        public List<Printer> ListALL()
        {
            return _bankRepo.ListAll();
        }

        public List<Printer> ListALLAsNoTracking()
        {
            return _bankRepo.ListAllAsNoTracking();
        }
        public Printer getOne(int id)
        {
            return _bankRepo.listForID(id);
        }


        public int insert(Printer bank)
        {
            return _bankRepo.insert(bank);
        }

        public int delete(Printer bank)
        {
            return _bankRepo.remove(bank);
        }

        public int update(Printer bank)
        {
            return _bankRepo.update(bank);
        }

        public int deleteFoId(int id)
        {
            return _bankRepo.removeForID(id);
        }

    }
}
