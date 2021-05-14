using Domain.Domain.Entities.Assistants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public int CompanyTypeId { get; set; }
        public string CompanyID { get; set; } // Registro Comercial da Empresa
        public string Nif { get; set; } // Também é o tax Registration Number 
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Tel1 { get; set; }
        public string Fax { get; set; }
        public string Fax2 { get; set; }
        public string ContaBanco1 { get; set; }
        public string ContaBanco2 { get; set; }
        public string Endereco { get; set; }
        public string UrlLogo { get; set; }
        public string UrlSite { get; set; }
        public int CidadeId { get; set; }
        public virtual City Cidade { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool flagEmpresaProdutoraSistema { get; set; } = false;
    }
}
