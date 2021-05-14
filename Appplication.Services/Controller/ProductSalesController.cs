using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductSalesController
    {
        ProductSalesRepository _productSalesRepo = new ProductSalesRepository();

        public List<ProductSales> ListALL()
        {
            return _productSalesRepo.ListAll();
        }

        public List<ProductSales> ListALLAsNoTracking()
        {
            return _productSalesRepo.ListAllAsNoTracking();
        }

        public int insert(ProductSales productSales)
        {
            return _productSalesRepo.insert(productSales);
        }

        public int delete(ProductSales productSales)
        {
            return _productSalesRepo.remove(productSales);
        }

        public int update(ProductSales productSales)
        {
            return _productSalesRepo.update(productSales);
        }

        public int deleteFoId(int id)
        {
            return _productSalesRepo.removeForID(id);
        }

        public object view1(string search)
        {
            return _productSalesRepo.view1(search);
        }

    }
}
