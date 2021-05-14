using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class CountryController
    {
        CountryRepository _countryRepository = new CountryRepository();

        public List<Country> ListALL()
        {
            return _countryRepository.ListAll();
        }

        public List<Country> ListALLAsNoTracking()
        {
            return _countryRepository.ListAllAsNoTracking();
        }

        public int insert(Country country)
        {
            return _countryRepository.insert(country);
        }
        public Country getOne(int id)
        {
            return _countryRepository.listForID(id);
        }
        public int delete(Country country)
        {
            return _countryRepository.remove(country);
        }

        public int update(Country country)
        {
            return _countryRepository.update(country);
        }

        public int deleteFoId(int id)
        {
            return _countryRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _countryRepository.view1(search);
        }
    }
}
