using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Customer.Where(c => c.Id.ToString().Contains(search) || 
                    c.Cliente.Contains(search)) select new {
                        item.Id,
                        item.Nif,
                        item.Cliente,
                        item.Sexo,
                        item.DataNascimento,
                        item.Email,
                        item.Tel,
                        item.Fax,
                        item.Endereco,
                        item.Cidade.Cidade,
                        item.Cidade.Pais.Pais,
                        item.Postal,
                        item.DataCadastro
                    }).ToList();
        }

        public List<int> view4(string search)
        {
            List<int> idL = new List<int>();
            search = search.ToLower();
            foreach(var items in (from item in _contextDB.Customer.Where(c =>
                    c.Cliente.Contains(search))
                    select new
                    {
                        item.Id,
                    }).ToList())
            {
                idL.Add(items.Id);
            }
            return idL;
        }




        public object view2(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Customer.Where(c => c.Id.ToString().Contains(search) || 
                    c.Cliente.Contains(search)) select new {
                        item.Id, item.Nif, item.Cliente, item.Sexo,
                        item.DataNascimento,
                        item.Email, item.Tel, item.Fax, item.Endereco, item.Cidade.Cidade,
                        item.Cidade.Pais.Pais, item.Postal }).ToList();

        }

        public object view3(string search)
        {
            search = search.ToLower();
            return (from item in _contextDB.Customer.Where(c => c.Id.ToString().Contains(search) ||
                    c.Cliente.Contains(search))
                    select new
                    {
                        item.Id,
                        item.Cliente,
                        item.Nif,
                        item.Sexo,
                        item.Tel,
                        item.Endereco,
                    }).ToList();

        }
    }
}
