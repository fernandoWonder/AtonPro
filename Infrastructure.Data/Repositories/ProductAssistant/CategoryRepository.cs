using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public object view1(string search)
        {
            search = search.ToString();

            return (from item in _contextDB.Category.Where(c => c.Id.ToString().Contains(search) || c.Categoria.Contains(search))
                    select new { item.Id, item.Categoria, item.Descricao, item.DataCadastro }).ToList();
        }
    }
}
