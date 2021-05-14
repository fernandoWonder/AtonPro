using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class CategoryController
    {
        CategoryRepository _categRepository = new CategoryRepository();

        public List<Category> ListALL()
        {
            return _categRepository.ListAll();
        }

        public List<Category> ListALLAsNoTracking()
        {
            return _categRepository.ListAllAsNoTracking();
        }
        public Category getOne(int id)
        {
            return _categRepository.listForID(id);
        }
        public int insert(Category category)
        {
            return _categRepository.insert(category);
        }

        public int delete(Category category)
        {
            return _categRepository.remove(category);
        }

        public int update(Category category)
        {
            return _categRepository.update(category);
        }

        public int deleteFoId(int id)
        {
            return _categRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _categRepository.view1(search);
        }
    }
}
