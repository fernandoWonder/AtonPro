using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Repositories.ProductAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class CompositionController
    {
        CompositionRepository _compositionRtory = new CompositionRepository();

        public List<Composition> ListALL()
        {
            return _compositionRtory.ListAll();
        }

        public List<Composition> ListALLAsNoTracking()
        {
            return _compositionRtory.ListAllAsNoTracking();
        }
        public Composition getOne(int id)
        {
            return _compositionRtory.listForID(id);
        }
        public Composition getLast()
        {
            return _compositionRtory.getLast();
        }
        public int insert(Composition composition)
        {
            return _compositionRtory.insert(composition);
        }

        public int delete(Composition composition)
        {
            return _compositionRtory.remove(composition);
        }

        public int update(Composition composition)
        {
            return _compositionRtory.update(composition);
        }

        public int deleteFoId(int id)
        {
            return _compositionRtory.removeForID(id);
        }

        public object view1(string search)
        {
            return _compositionRtory.view1(search);
        }

        public object view2(string search)
        {
            return _compositionRtory.view2(search);
        }
    }
}
