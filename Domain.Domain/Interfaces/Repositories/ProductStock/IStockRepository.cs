using Domain.Domain.Entities.ProductStock;
using System;

namespace Domain.Domain.Interfaces.Repositories.ProductStock
{
    public interface IStockRepository : IBaseRepository<Stock>
    {
        object view1(string search, int companyTypeId);
        object view2(string search, int companyTypeId);

        object viewProductStockArmazem(int idArmazem, int companyId);
        object viewProductStockArmazem2(int idArmazem, int companyId);

        Stock getStockArmazemProduct(int idProduct, int idStorage, int companyTypeId);
    }
}
