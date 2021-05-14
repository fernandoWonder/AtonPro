using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class BaseUnitRepository : BaseRepository<BaseUnit>, IBaseUnitRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();

            return (from bu in _contextDB.BaseUnit.Where(c => (c.Id.ToString().Contains(search) || c.Unidade.Contains(search)) && c.FlagState)
                    select new { bu.Id, bu.Simbolo, bu.Unidade, bu.DataCadastro }).ToList();
        }
    }
}
