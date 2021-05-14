using Appplication.Statics;
using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductController
    {
        protected Company _currentCompany = SystemInfoCurrent.getCurrentCompany();
        protected ProductRepository _productRepository = new ProductRepository();

        public List<Product> ListALL()
        {
            if (_currentCompany.CompanyTypeId == 2)
                return _productRepository.ListAll().Where(c => c.MotivoISE.RegimeSimplificado && c.FlagState).ToList();
            if (_currentCompany.CompanyTypeId == 3)
                return _productRepository.ListAll().Where(c => c.MotivoISE.RegimeExclusao && c.FlagState).ToList();
            return _productRepository.ListAll().Where(c => c.FlagState).ToList();
            
        }

        public Product getLast()
        {
           // return _productRepository.getLast();
            return ListALLAsNoTracking().LastOrDefault();
        }        

        public List<Product> ListALLAsNoTracking()
        {
            if (_currentCompany.CompanyTypeId == 2)
                return _productRepository.ListAllAsNoTracking().Where(c => c.MotivoISE.RegimeSimplificado && c.FlagState).ToList();
            if (_currentCompany.CompanyTypeId == 3)
                return _productRepository.ListAllAsNoTracking().Where(c => c.MotivoISE.RegimeExclusao && c.FlagState).ToList();
            return _productRepository.ListAllAsNoTracking().Where(c => c.FlagState).ToList();
        }
        public Product getOne(int id)
        {
            return _productRepository.listForID(id);
        }

        public Product getForCodigoBarra(string codigoBarra)
        {
            return _productRepository.getForCodigoBarra(codigoBarra);
        }

        public Product getForCodigoProduto(string codigoProduto)
        {
            return _productRepository.getForCodigoProduto(codigoProduto);
        }

        public int insert(Product product)
        {
            return _productRepository.insert(product);
        }

        public int delete(Product product)
        {
            return _productRepository.remove(product);
        }
        public int removeProduct(Product product)
        {
            return _productRepository.removeProduct(product);
        }

        public int update(Product product)
        {
            return _productRepository.update(product);
        }

        public int deleteFoId(int id)
        {
            return _productRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _productRepository.view1(search);
        }

        public object view2(string search)
        {
            return _productRepository.view2(search);
        }

        public object view3(string search)
        {
            return _productRepository.view3(search);
        }

    }
}
