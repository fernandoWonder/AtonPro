using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class CompositionProductsRepository : BaseRepository<CompositionProducts>, ICompositionProductsRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();

            return (from item in _contextDB.CompositionProducts.Where(c => c.Id.ToString().Contains(search) || 
                    c.Composicao.Produto.Descricao.Contains(search) || c.Composicao.Composicao.Contains(search) || c.ComposicaoId.ToString().Contains(search) )
                    select new { item.Id, item.Composicao.Composicao, Artigo= item.Produto.Descricao, item.Descricao, item.DataCadastro}).ToList();
        }

        public object view2(string search)
        {
            throw new NotImplementedException();
        }
    }
}
