using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repositories.Documents
{
    public class ProductRetreatRepository :  BaseRepository<ProductRetreat> , IProductReatretRepository
    {
        public List<int> view1(string search, string armazem)
        {
            if (armazem=="GERAL")
            {
                armazem = "";
            }
            List<int> lista = new List<int>();
            foreach (var item in (from p in _contextDB.ProductRetreat.Where(c => c.Produto.Descricao.Contains(search)&& c.Armazem.Armazem.Contains(armazem))   select new { p.Id}))
            {
                lista.Add(item.Id);
            }

            return lista;
        }
        public List<int> view2(string search, string armazem, DateTime date1, DateTime date2 )
        {
            List<int> lista = new List<int>();
            foreach (var item in (from p in _contextDB.ProductRetreat.Where(c => c.Produto.Descricao.Contains(search) && c.Armazem.Armazem.Contains(armazem) && c.DataCadastro >= date1 && c.DataCadastro <= date2) select new { p.Id }))
            {
                lista.Add(item.Id);
            }

            return lista;
        }

    }
}
