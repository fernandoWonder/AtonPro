using System;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Interfaces.Repositories.Documents;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Data.Repositories.Documents
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public object view1(string search)
        {
            search = search.ToLower();
            var query = from fat in _contextDB.Invoice.Where(c => c.FlagState && (c.Codigo.ToString().Contains(search) || c.Id.ToString().Contains(search) || c.Cliente.Cliente.Contains(search) || c.User.Usuario.Contains(search) ))
                        select new { fat.Id, fat.Codigo, fat.InvoiceNo, fat.Cliente.Cliente, fat.TipoDocumento.Tipo, fat.Series.Serie, fat.FormaPagamentoId, fat.Desconto, fat.TotalIncidencia, fat.TotalImposto, TotalGeral = (fat.TotalImposto + fat.TotalIncidencia), fat.ValorPago, fat.Troco, fat.Observacao, fat.User.Usuario, fat.DataCadastro };

            return query.ToList();
        }

        public List<int> view2(string search)
        {
            List<int> idL = new List<int>();
            foreach (var item in (from fat in _contextDB.Invoice.Where(c => c.FlagState && c.Cliente.Cliente.Contains(search))
                                  select new { fat.Id }))
            {
                idL.Add(item.Id);
            }
            return idL;
        }
        public List<int> view3(string search, DateTime date1,DateTime date2)
        {
            List<int> idL = new List<int>();
            foreach (var item in (from fat in _contextDB.Invoice.Where(c => c.FlagState &&  c.Cliente.Cliente.Contains(search) && c.DataCadastro >= date1 && c.DataCadastro <= date2 )
                                  select new { fat.Id}))
            {
                idL.Add(item.Id);
            }
            return idL;
            
        }

        public List<ProductSales> productsInvoice(int idInvoice)
        {
            return _contextDB.Invoice.Where(c => c.Id == idInvoice).ToList().First().ProductsSales.ToList();
        }

        public Invoice lastInvoiceInSerieAndType(int idSerie, string idTipoDocumento)
        {
            return _contextDB.Invoice.Where(c => c.SeriesId == idSerie && c.TipoDocumentoId == idTipoDocumento).ToList().LastOrDefault();
        }

        public Invoice getInvoiceForNo(string invoiceNo)
        {
            return _contextDB.Invoice.Where(c => c.InvoiceNo.ToLower().Equals(invoiceNo.ToLower())).FirstOrDefault();
        }

    }
}
