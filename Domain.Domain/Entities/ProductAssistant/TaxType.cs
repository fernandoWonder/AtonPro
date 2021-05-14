using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class TaxType
    {
        // Aqui Será preenchido o tipo de Imposto: IVA, NS
        // Quando for ISE Vai abrir a lista de motivos isenção
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<TaxReasonExemption> MotivosIsencao { get; set; } // Aplicado Somente para ISE
        public virtual ICollection<TaxCode> Taxas { get; set; } // Aplicado Somente para IVA
        /* Tipos de Imposto: Normal (Nor), Isenção (ISS) etc.   */

    }
}
