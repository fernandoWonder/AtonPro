using Appplication.Statics;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Appplication.Controller
{
    public class ProviderController
    {
        ProviderRepository _pRepository = new ProviderRepository();

        public List<Provider> ListALL()
        {
            return _pRepository.ListAll();
        }

        public List<Provider> ListALLAsNoTracking()
        {
            return _pRepository.ListAllAsNoTracking();
        }

        public List<Invoice> getInvoices(int idProvider)
        {
            return getOne(idProvider).Faturas.ToList();
        }

        public decimal getSaldo(int idProvider)
        {
            return getInvoices(idProvider).Sum(c => c.TotalLiquidar);
        }

        public Provider getOne(int id)
        {
            return _pRepository.listForID(id);
        }

        public int insert(Provider provider)
        {
            provider.Conta_Corrente = Methods.getCurrentAccountProvider();
            return _pRepository.insert(provider);
        }

        public int delete(Provider provider)
        {
            return _pRepository.remove(provider);
        }

        public void Dispose()
        {
            _pRepository.Dispose();
        }

        public int update(Provider provider)
        {
            return _pRepository.update(provider);
        }

        public int deleteFoId(int id)
        {
            return _pRepository.removeForID(id);
        }

        public object view1(string search)
        {
            return _pRepository.view1(search);
        }

        public object view2(string search)
        {
            return _pRepository.view2(search);
        }

        public object view3(string search)
        {
            return _pRepository.view3(search);
        }

    }
}
