

using System;
using Domain.Domain.Entities.Assistants;
using Domain.Domain.Interfaces.Repositories.Assistants;
using System.Linq;

namespace Infrastructure.Data.Repositories.Assistants
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from cidade in _contextDB.City.Where(c => c.Id.ToString().Contains(search) || c.Cidade.Contains(search))
                    select new { cidade.Id, cidade.Cidade, cidade.Pais.Pais }).ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from cidade in _contextDB.City.Where(c => c.Id.ToString().Contains(search) || c.Cidade.Contains(search))
                    select new { cidade.Id, cidade.Cidade, cidade.Pais.Pais, cidade.DataCadastro }).ToList();
        }
    }
}
