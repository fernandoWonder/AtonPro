using Infrastructure.Data.Repositories.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller.Assistents
{
    public class TabelaImposto
    {
        BankRepository _bankRepo = new BankRepository();

        public decimal Taxa { get; set; }
        public decimal TotalIncidencia { get; set; }
        public decimal TotalTaxa { get; set; }
        public string Motivo { get; set; }
        public string TaxType { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDescription { get; set; }

    }
}
