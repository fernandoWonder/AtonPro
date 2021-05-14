using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Data.Repositories.Documents
{
    public class ProductEntryRepository : BaseRepository<ProductEntry>, IProductEntryRepository
    {
        public List<int> view1(string search)
        {
            search = search.ToLower();
            List<int> idL = new List<int>();
            foreach (var item in (from pe in _contextDB.ProductEntry.Where(c =>c.Produto.Descricao.Contains(search)) select new { pe.Id }).ToList())
            {
                idL.Add(item.Id);
            }
            return idL;
         }

        public object view2(string search)
        {
            search = search.ToLower();
            return (from pe in _contextDB.ProductEntry.Where(c => c.Id.ToString().Contains(search) || c.Produto.Descricao.Contains(search) || c.Fornecedor.Fornecedor.Contains(search) || c.DataCadastro.ToString().Contains(search))
                    select new { pe.Id, pe.Produto.Descricao, pe.Fornecedor.Fornecedor, pe.Preco, pe.Quantidade, pe.PrecoTotal }).ToList();
        }
        public List<int> view3(string search,DateTime date1, DateTime date2)
        {
            List<int> idL = new List<int>();
            foreach (var item in (from pe in _contextDB.ProductEntry.Where(c => c.Produto.Descricao.Contains(search) && c.DataCadastro >= date1 && c.DataCadastro <= date2).ToList() select new { pe.Id }))
            {
                idL.Add(item.Id);
            }
            return idL;
        }
    }
}
