using Domain.Domain.Entities.Assistants;
using Infrastructure.Data.Repositories.Assistants;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class CityController
    {
        CityRepository _cityRepository = new CityRepository();

        public List<City> ListALL()
        {
            return _cityRepository.ListAll();
        }

        public List<City> ListALLAsNoTracking()
        {
            return _cityRepository.ListAllAsNoTracking();
        }

        public int insert(City city)
        {
            return _cityRepository.insert(city);
        }
        public City getOne(int id)
        {
            return _cityRepository.listForID(id);
        }
        public int delete(City city)
        {
            return _cityRepository.remove(city);
        }

        public int update(City city)
        {
            return _cityRepository.update(city);
        }

        public int deleteFoId(int id)
        {
            return _cityRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _cityRepository.view1(search);
        }

    }
}
