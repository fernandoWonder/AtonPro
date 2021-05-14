using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class FamilyRestController
    {
        FamilyRestRepository _familyRestRepo = new FamilyRestRepository();

        public int insert(FamilyRest family)
        {
            return _familyRestRepo.insert(family);
        }
        public List<FamilyRest> ListAll()
        {
            return _familyRestRepo.ListAll();
        }
        public List<FamilyRest> ListAllAsNoTracking()
        {
            return _familyRestRepo.ListAllAsNoTracking();
        }
        public FamilyRest listForId(int id)
        {
            return _familyRestRepo.listForID(id);
        }
        public int remove(FamilyRest FamilyRest)
        {
            return _familyRestRepo.remove(FamilyRest);
        }
        public int removeForId(int id)
        {
            return _familyRestRepo.removeForID(id);
        }
        public int update(FamilyRest FamilyRest)
        {
            return _familyRestRepo.update(FamilyRest);
        }
     
    }
}
