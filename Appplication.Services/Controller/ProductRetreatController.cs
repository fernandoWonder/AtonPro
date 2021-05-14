using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ProductRetreatController
    {
        ProductRetreatRepository _productRetreatRepository = new ProductRetreatRepository();

        public List<ProductRetreat> ListALLAsNoTracking()
        {
            return _productRetreatRepository.ListAllAsNoTracking();
        }
        public ProductRetreat getOne(int id)
        {
            return _productRetreatRepository.listForID(id);
        }

        public int insert(ProductRetreat productRetreat)
        {
            return _productRetreatRepository.insert(productRetreat);
        }

        public int delete(ProductRetreat productRetreat)
        {
            return _productRetreatRepository.remove(productRetreat);
        }

        public int update(ProductRetreat productRetreat)
        {
            return _productRetreatRepository.update(productRetreat);
        }

        public int deleteFoId(int id)
        {
            return _productRetreatRepository.removeForID(id);
        }
        public List<ProductRetreat> view2(string search, string armazem, DateTime date1, DateTime date2)
        {
            if (armazem=="GERAL")
            {
                armazem = "";
            }
            List<ProductRetreat> lista = new List<ProductRetreat>();
            foreach (int id in _productRetreatRepository.view2(search,armazem, date1, date2))
            {
                lista.Add(getOne(id));
            }

            return lista;
        }
        public List<ProductRetreat> view1(string search, string armazem)
        {
            if (armazem == "GERAL")
            {
                armazem = "";
            }
            List<ProductRetreat> lista = new List<ProductRetreat>();
            foreach (int id in _productRetreatRepository.view1(search, armazem))
            {
                lista.Add(getOne(id));
            }

            return lista;
        }
    }
}
