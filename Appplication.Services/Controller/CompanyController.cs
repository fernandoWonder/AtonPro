using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class CompanyController
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public List<Company> ListALL()
        {
            return _companyRepository.ListAll();
        }

        public List<Company> ListALLAsNoTracking()
        {
            return _companyRepository.ListAllAsNoTracking();
        }
        public Company getOne(int id)
        {
            return _companyRepository.listForID(id);
        }
        public int insert(Company company)
        {
            return _companyRepository.insert(company);
        }

        public int delete(Company company)
        {
            return _companyRepository.remove(company);
        }

        public int update(Company company)
        {
            return _companyRepository.update(company);
        }

        public int deleteFoId(int id)
        {
            return _companyRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _companyRepository.view1(search);
        }
    }
}
