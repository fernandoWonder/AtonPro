using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository()
        {
            
        }

        public object view1(string search)
        {
            search = search.ToLower();
            return (from pais in _contextDB.Country.Where(c => c.Id.ToString().Contains(search) || c.Pais.Contains(search) ) select new { pais.Id, pais.Pais, pais.Sigla }).ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from pais in _contextDB.Country.Where(c => c.Id.ToString().Contains(search) || c.Pais.Contains(search)) select new { pais.Id, pais.Pais, pais.Sigla, pais.DataCadastro }).ToList();
        }
    }
}
