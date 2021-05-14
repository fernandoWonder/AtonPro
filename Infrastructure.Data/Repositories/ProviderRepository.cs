using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class ProviderRepository : BaseRepository<Provider>, IProviderRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            var query = from provider in _contextDB.Provider.Where(c => c.Id.ToString().Contains(search) || 
                        c.Fornecedor.Contains(search) || c.Nif.Contains(search) )
                        select new { provider.Id, provider.Nif, provider.Fornecedor, provider.Email, provider.Tel,
                            provider.Fax, provider.Endereco, provider.Cidade.Pais.Pais, provider.Cidade.Cidade};
            return query.ToList();
        }

        public object view2(string search)
        {
            search = search.ToLower();
            var query = from provider in _contextDB.Provider.Where(c => c.Id.ToString().Contains(search) ||
                        c.Fornecedor.Contains(search) || c.Nif.Contains(search))
                        select new { provider.Id, provider.Nif, provider.Fornecedor, provider.Email, provider.Tel,
                            provider.Fax, provider.Endereco, provider.Cidade.Pais.Pais, provider.Cidade.Cidade };
            return query.ToList();
        }

        public object view3(string search)
        {
            search = search.ToLower();
            var query = from provider in _contextDB.Provider.Where(c => c.Id.ToString().Contains(search) ||
                        c.Fornecedor.Contains(search) || c.Nif.Contains(search))
                        select new
                        {
                            provider.Id,
                            provider.Nif,
                            provider.Fornecedor,
                            provider.Email,
                            provider.Tel,
                            provider.Endereco,
                        };
            return query.ToList();
        }

    }
}
