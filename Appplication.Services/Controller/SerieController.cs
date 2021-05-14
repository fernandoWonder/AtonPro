using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class SerieController
    {
        SeriesRepository _serieRepo = new SeriesRepository();

        public List<Series> ListALL()
        {
            return _serieRepo.ListAll();
        }

        public List<Series> ListALLAsNoTracking()
        {
            return _serieRepo.ListAllAsNoTracking();
        }

        public Series getOne(int id)
        {
            return _serieRepo.listForID(id);
        }

        public int insert(Series serie)
        {
            return _serieRepo.insert(serie);
        }

        public int delete(Series serie)
        {
            return _serieRepo.remove(serie);
        }

        public int update(Series serie)
        {
            return _serieRepo.update(serie);
        }

        public int deleteFoId(int id)
        {
            return _serieRepo.removeForID(id);
        }

        public object view1(string search)
        {
            return _serieRepo.view1(search);
        }

    }
}
