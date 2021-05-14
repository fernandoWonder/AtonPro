using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class InvoiceController
    {
        InvoiceRepository _invoiceRep = new InvoiceRepository();

        public List<Invoice> ListALL()
        {
            return _invoiceRep.ListAll();
        }

        public List<Invoice> ListALLAsNoTracking()
        {
            return _invoiceRep.ListAllAsNoTracking();
        }

        public Invoice getOne(int id)
        {
            return _invoiceRep.listForID(id);
        }

        public Invoice getForInvoiceNo(string invoiceNo)
        {
            return _invoiceRep.getInvoiceForNo(invoiceNo);
        }

        public int insert(Invoice invoice)
        {
            return _invoiceRep.insert(invoice);
        }

        public int insert(Invoice invoice, int idUser, int idAccount)
        {
            CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();
            CurrentAccountSystem account = _currentAccountController.getOne(idAccount);
            if(invoice.ValorPago > 0)
                account.Saldo += (invoice.ValorPago - invoice.Troco);
            else
                account.Saldo += 0;
            _currentAccountController.update(account);
            return _invoiceRep.insert(invoice);
        }

        public int delete(Invoice invoice)
        {
            return _invoiceRep.remove(invoice);
        }

        public int update(Invoice invoice)
        {
            return _invoiceRep.update(invoice);
        }

        public int deleteFoId(int id)
        {
            return _invoiceRep.removeForID(id);
        }

        public List<ProductSales>  productsInvoice(int idInvoice)
        {
            return _invoiceRep.productsInvoice(idInvoice);
        }

        public object view1(string search)
        {
            return _invoiceRep.view1(search);
        }
        public List<Invoice> view2(string search)
        {
            List<Invoice> lista = new List<Invoice>();
            foreach (int item in _invoiceRep.view2(search))
            {
                lista.Add(_invoiceRep.listForID(item));
            }
            return lista;
        }
        public List<Invoice> view3(string search,DateTime date1,DateTime date2)
        {
            List<Invoice> lista = new List<Invoice>();
            foreach (int item in _invoiceRep.view3(search,date1,date2))
            {
                lista.Add(_invoiceRep.listForID(item));
            }
            return lista;

            
        }

        public Invoice lastInvoiceInSerieAndType(int idSerie, string idTipoDocumento)
        {
            return _invoiceRep.lastInvoiceInSerieAndType(idSerie, idTipoDocumento);
        }

        public void Dispose()
        {
            _invoiceRep.Dispose();
        }

    }
}
