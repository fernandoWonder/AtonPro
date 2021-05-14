using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductTypeController
    {
        ProductTypeRepository _productTypeRepository = new ProductTypeRepository();

        public List<ProductType> ListALL()
        {
            return _productTypeRepository.ListAll();
        }

        public List<ProductType> ListALLAsNoTracking()
        {
            return _productTypeRepository.ListAllAsNoTracking();
        }

        public int insert(ProductType productType)
        {
            return _productTypeRepository.insert(productType);
        }

        public int delete(ProductType productType)
        {
            return _productTypeRepository.remove(productType);
        }

        public int update(ProductType productType)
        {
            return _productTypeRepository.update(productType);
        }

        public int deleteFoId(int id)
        {
            return _productTypeRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _productTypeRepository.view1(search);
        }

    }
}
