using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class CompositionRepository : BaseRepository<Composition>, ICompositionRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Composition.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Composicao, Artigo = item.Produto.Descricao, item.DataCadastro}).ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Composition.Where(c => c.Id.ToString().Contains(search))
                    select new { item.Id, item.Composicao, Artigo = item.Produto.Descricao }).ToList();
        }
    }
}
