using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class SeriesRepository : BaseRepository<Series>, ISeriesRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();

            return (from se in _contextDB.Series.Where(c => (c.Id.ToString().Contains(search) || c.Serie.Contains(search)) && c.FlagState)
                    select new { se.Id, se.Serie, se.AnoInicio, se.AnoTermino, se.DataCadastro }).ToList();
        }
    }
}
