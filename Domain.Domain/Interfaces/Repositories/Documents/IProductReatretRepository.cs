using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Repositories.Documents
{
   public interface IProductReatretRepository : IBaseRepository<ProductRetreat>
    {
        List<int> view1(string search,string armazem);
        List<int> view2(string search,string armazem,DateTime date1,DateTime date2);
    }
}
