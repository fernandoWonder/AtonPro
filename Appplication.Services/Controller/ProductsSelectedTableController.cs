using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Repositories.Temp;
using Domain.Domain.Entities.Temp;
namespace Appplication.Controller
{
    public class ProductsSelectedTableController
    {
        ProductsSelectedTableRepository _productSelectedTableRepository = new ProductsSelectedTableRepository();

        public int insert(ProductSellectedTable productSellectedTable)
        {
            return _productSelectedTableRepository.insert(productSellectedTable);
        }
        public List<ProductSellectedTable> ListAll()
        {
            return _productSelectedTableRepository.ListAll();
        }
        
        public List<ProductSellectedTable> ListAllAsNoTracking()
        {
            return _productSelectedTableRepository.ListAllAsNoTracking();
        }
        public ProductSellectedTable listForId(int id)
        {
            return _productSelectedTableRepository.listForID(id);
        }
        public int remove(ProductSellectedTable reserve)
        {
            return _productSelectedTableRepository.remove(reserve);
        }
        public int removeForId(int id)
        {
            return _productSelectedTableRepository.removeForID(id);
        }
        public int update(ProductSellectedTable reserve)
        {
            return _productSelectedTableRepository.update(reserve);
        }
        public object view1(string query)
        {
            return _productSelectedTableRepository.view1(query);
        }
        public List<ProductSellectedTable> view1(string query,int idMesa)
        {
            return _productSelectedTableRepository.view1(query,idMesa);
        }

    }
}
