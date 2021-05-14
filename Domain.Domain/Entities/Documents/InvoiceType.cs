using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities.Documents
{
    public class InvoiceType
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public bool SalesInvoices { get; set; } = true;
        public bool WorkDocuments { get; set; } = false;
        public bool Payments { get; set; } = false;
        public bool Purchase { get; set; } = false;
        public bool Seller { get; set; } = true;
        public virtual ICollection<Invoice> Faturas { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
