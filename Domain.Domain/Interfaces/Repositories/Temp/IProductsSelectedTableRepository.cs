using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Repositories.Temp
{
    public interface IProductsSelectedTableRepository : IBaseRepository<ProductSellectedTable>
    {
         object view1(string query);
    }
}
