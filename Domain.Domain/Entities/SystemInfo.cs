using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class SystemInfo
    {
        // Virá as informações do sistema (versão, nº registro, etc...)
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string SystemName { get; set; }
        public string SystemVersion { get; set; }
        public string ProductCompanyTaxID { get; set; } // Nif da produtora do software
        public string ProductID
        {
            get
            {
                return SystemName + "/" + CompanyName;
            }
        }
        public string SoftwareValidationNumber { get; set; }
        public string TaxAccountBasis { get; set; }
        public string Tel { get; set; }
        public string UrlSite { get; set; }
        public string AudiFileVersion {
            get
            {
                return "1.01_01";
            }
        }
        public string FiscalYear {
            get
            {
                return "2021";
            }
        }
    }
}
