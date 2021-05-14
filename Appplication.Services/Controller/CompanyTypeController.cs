using Domain.Domain.Entities.Assistants;
using Infrastructure.Data.Repositories.Assistants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class CompanyTypeController
    {
        CompanyTypeRepository _companyTypeRepo = new CompanyTypeRepository();

        public List<CompanyType> ListALL()
        {
            return _companyTypeRepo.ListAll();
        }

        public List<CompanyType> ListALLAsNoTracking()
        {
            return _companyTypeRepo.ListAllAsNoTracking();
        }
        public CompanyType getOne(int id)
        {
            return _companyTypeRepo.listForID(id);
        }
        public int insert(CompanyType companyType)
        {
            return _companyTypeRepo.insert(companyType);
        }

        public int delete(CompanyType companyType)
        {
            return _companyTypeRepo.remove(companyType);
        }

        public int update(CompanyType companyType)
        {
            return _companyTypeRepo.update(companyType);
        }

        public int deleteFoId(int id)
        {
            return _companyTypeRepo.removeForID(id);
        }

    }
}
