using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductEntryController
    {
        ProductEntryRepository _prodEntryRep = new ProductEntryRepository();

        public List<ProductEntry> ListALL()
        {
            return _prodEntryRep.ListAll();
        }

       
        public List<ProductEntry> ListALLAsNoTracking()
        {
            return _prodEntryRep.ListAllAsNoTracking();
        }
        public ProductEntry getOne(int id)
        {
            return _prodEntryRep.listForID(id);
        }
        public int insert(ProductEntry productEntry)
        {
            return _prodEntryRep.insert(productEntry);
        }

        public int delete(ProductEntry productEntry)
        {
            return _prodEntryRep.remove(productEntry);
        }

        public int update(ProductEntry productEntry)
        {
            return _prodEntryRep.update(productEntry);
        }

        public int deleteFoId(int id)
        {
            return _prodEntryRep.removeForID(id);
        }

        public List<ProductEntry> view1(string search)
        {
            
            List<ProductEntry> lista = new List<ProductEntry>();
            foreach (int id in _prodEntryRep.view1(search))
            {
                lista.Add(this.getOne(id));
            }

            return lista;
        }

        public object view2(string search)
        {
            return _prodEntryRep.view2(search);
        }
        public List<ProductEntry> view3(string search,DateTime date1,DateTime date2)
        {
         
            List<ProductEntry> lista = new List<ProductEntry>();
            foreach (int id in _prodEntryRep.view3(search, date1, date2))
            {
                 lista.Add(this.getOne(id));
            }

            return lista;
        }

    }
}
