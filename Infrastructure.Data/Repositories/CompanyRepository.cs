using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            var query = from emp in _contextDB.Company.Where(c => c.Id.ToString().Contains(search) || c.Empresa.Contains(search) || c.Nif.Contains(search)) select new { emp.Id, emp.Nif, emp.Empresa, emp.Email, emp.Endereco, emp.Cidade.Pais, emp.Cidade.Cidade, emp.Tel, emp.Tel1, emp.Fax, emp.Fax2, emp.CompanyType.Tipo };
            return query.ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            var query = from emp in _contextDB.Company.Where(c => c.Id.ToString().Contains(search) || c.Empresa.Contains(search) || c.Nif.Contains(search)) select new { emp.Id, emp.Nif, emp.Empresa, emp.Email, emp.Endereco, emp.Cidade.Pais, emp.Cidade.Cidade, emp.Tel, emp.Tel1, emp.Fax, emp.Fax2, emp.CompanyType.Tipo, emp.DataCadastro };
            return query.ToList();
        }
    }
}
