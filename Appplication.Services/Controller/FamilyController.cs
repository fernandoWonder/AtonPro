using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
     public class FamilyController
    {

        FamilyRepository _familyRestRepo = new FamilyRepository();

        public int insert(Family family)
        {
            return _familyRestRepo.insert(family);
        }
        public List<Family> ListAll()
        {
            return _familyRestRepo.ListAll();
        }
        public List<Family> ListAllAsNoTracking()
        {
            return _familyRestRepo.ListAllAsNoTracking();
        }
        public Family listForId(int id)
        {
            return _familyRestRepo.listForID(id);
        }
        public int remove(Family FamilyRest)
        {
            return _familyRestRepo.remove(FamilyRest);
        }
        public int removeForId(int id)
        {
            return _familyRestRepo.removeForID(id);
        }
        public int update(Family FamilyRest)
        {
            return _familyRestRepo.update(FamilyRest);
        }
    }
}
