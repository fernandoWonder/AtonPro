using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System.Collections.Generic;
namespace Appplication.Controller
{
    public class CompositionProductsController
    {
        CompositionProductsRepository _compositionProductsRep = new CompositionProductsRepository();

        public List<CompositionProducts> ListALL()
        {
            return _compositionProductsRep.ListAll();
        }

        public List<CompositionProducts> ListALLAsNoTracking()
        {
            return _compositionProductsRep.ListAllAsNoTracking();
        }

        public CompositionProducts getOne(int id)
        {
            return _compositionProductsRep.listForID(id);
        }

        public CompositionProducts getLast(int id)
        {
            return _compositionProductsRep.getLast();
        }

        public int insert(CompositionProducts compositionProducts)
        {
            return _compositionProductsRep.insert(compositionProducts);
        }

        public int delete(CompositionProducts compositionProducts)
        {
            return _compositionProductsRep.remove(compositionProducts);
        }

        public int update(CompositionProducts compositionProducts)
        {
            return _compositionProductsRep.update(compositionProducts);
        }

        public int deleteFoId(int id)
        {
            return _compositionProductsRep.removeForID(id);
        }

        public object view1(string search)
        {
            return _compositionProductsRep.view1(search);
        }

        public void Dispose()
        {
            _compositionProductsRep.Dispose();
        }
    }
}
