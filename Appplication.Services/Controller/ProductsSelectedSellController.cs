using Domain.Domain.Entities.Temp;
using Infrastructure.Data.Repositories.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductsSelectedSellController
    {
        ProductsSelectedSellRepository _productsSelectedSellRep = new ProductsSelectedSellRepository();

        public ProductsSelectedSellController()
        {
            _productsSelectedSellRep.Reset();
        }

        public void reset()
        {
            _productsSelectedSellRep.Reset();
     //       _productsSelectedSellRep.Dispose();
        }

        public List<ProductsSelectedSell> ListALL()
        {
            return _productsSelectedSellRep.ListAll();
        }

        public List<ProductsSelectedSell> ListALLAsNoTracking()
        {
            return _productsSelectedSellRep.ListAllAsNoTracking();
        }

        public ProductsSelectedSell getOne(int id)
        {
            return _productsSelectedSellRep.listForID(id);
        }

        public int insert(ProductsSelectedSell productsSelectedSell)
        {
            return _productsSelectedSellRep.insert(productsSelectedSell);
        }

        public int delete(ProductsSelectedSell productsSelectedSell)
        {
            return _productsSelectedSellRep.remove(productsSelectedSell);
        }

        public int update(ProductsSelectedSell productsSelectedSell)
        {
            return _productsSelectedSellRep.update(productsSelectedSell);
        }

        public int deleteFoId(int id)
        {
            return _productsSelectedSellRep.removeForID(id);
        }

        public object view1(string search)
        {
            return _productsSelectedSellRep.view1(search);
        }
    }
}
