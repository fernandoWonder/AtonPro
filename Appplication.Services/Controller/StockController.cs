using Appplication.Statics;
using Domain.Domain.Entities;
using Domain.Domain.Entities.ProductStock;
using Infrastructure.Data.Repositories.ProductStock;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class StockController
    {
        protected Company _currentCompany = SystemInfoCurrent.getCurrentCompany();
        StockRepository _stockRepository = new StockRepository();

        public List<Stock> ListALL()
        {
            return _stockRepository.ListAll();
        }

        public List<Stock> ListALLAsNoTracking()
        {
            return _stockRepository.ListAllAsNoTracking();
        }

        public Stock getOne(int id)
        {
            return _stockRepository.listForID(id);
        }

        public int insert(Stock stock)
        {
            return _stockRepository.insert(stock);
        }

        public int delete(Stock stock)
        {
            return _stockRepository.remove(stock);
        }

        public int update(Stock stock)
        {
            return _stockRepository.update(stock);
        }

        public int deleteFoId(int id)
        {
            return _stockRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _stockRepository.view1(search, _currentCompany.CompanyTypeId);
        }

        public object view2(string search)
        {
            return _stockRepository.view2(search, _currentCompany.CompanyTypeId);
        }

        public object viewProductStockArmazem(int idArmazem)
        {
            return _stockRepository.viewProductStockArmazem(idArmazem, _currentCompany.CompanyTypeId);
        }
        public object viewProductStockArmazemProduct(int idArmazem,string search)
        {
            return _stockRepository.viewProductStockArmazemProduct(idArmazem, search ,_currentCompany.CompanyTypeId);
        }
        public object viewProductStockArmazemForEntryAndRetreat(int idArmazem)
        {
            return _stockRepository.viewProductStockArmazemForEntryAndRetreat(idArmazem, _currentCompany.CompanyTypeId);
        }
        public object viewProductStockArmazem2(int idArmazem)
        {
            return _stockRepository.viewProductStockArmazem2(idArmazem, _currentCompany.CompanyTypeId);
        }

        public Stock getStockArmazemProduct(int idProduct, int idArmazem)
        {
            return _stockRepository.getStockArmazemProduct(idProduct ,idArmazem, _currentCompany.CompanyTypeId);
        }

    }
}
