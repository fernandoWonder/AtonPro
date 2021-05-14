using Appplication.Statics;
using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class CustomerController
    {
        CustomerRepository _customerRep = new CustomerRepository();

        public List<Customer> ListALL()
        {
            return _customerRep.ListAll();
        }

        public List<Customer> ListALLAsNoTracking()
        {
            return _customerRep.ListAllAsNoTracking();
        }

        public Customer getOne(int id)
        {
            return _customerRep.listForID(id);
        }

        public int insert(Customer customer)
        {
            customer.Conta_Corrente = Methods.getCurrentAccountCustomer();
            return _customerRep.insert(customer);
        }

        public int delete(Customer customer)
        {
            return _customerRep.remove(customer);
        }

        public void Dispose()
        {
            _customerRep.Dispose();
        }
        public int update(Customer customer)
        {
            return _customerRep.update(customer);
        }

        public int deleteFoId(int id)
        {
            return _customerRep.removeForID(id);
        }

        public object view1(string search)
        {
            return _customerRep.view1(search);
        }
        public List<Customer> view4(string search)
        {
            List<Customer> clientes = new List<Customer>();
            foreach (int item in _customerRep.view4(search))
            {
                clientes.Add(getOne(item));
            }
            return clientes;
        }

        public object view2(string search)
        {
            return _customerRep.view2(search);
        }

        public object view3(string search)
        {
            return _customerRep.view3(search);
        }

    }
}
