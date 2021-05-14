using Domain.Domain.Entities;
using Domain.Domain.Entities.Temp;
using Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Appplication.Controller
{
   public class TableController
    {
        TableRepository _tableRepository = new TableRepository();
        public List<Table> ListALL()
        {
            return _tableRepository.ListAll();
        }
        public List<Table> ListALLAsNoTracking()
        {
            return _tableRepository.ListAllAsNoTracking();
        }
        public Table getLast()
        {
            return _tableRepository.getLast();
        }
        public int insert(Table table)
        {
            return this._tableRepository.insert(table);
        }

        public int delete(Table table)
        {
            return _tableRepository.remove(table);
        }

        public int update(Table table)
        {
            return _tableRepository.update(table);
        }

        public int deleteFoId(int id)
        {
            return _tableRepository.removeForID(id);
        }
        public Table listForId(int id)
        {
            return _tableRepository.listForID(id);
        }

        public List<ProductSellectedTable> getProductsSellected(int id)
        {
            return listForId(id).productsSellectedTable.ToList();
        }

    }
}
