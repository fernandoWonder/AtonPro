using Domain.Domain.Entities.Assistants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class TaxReasonExemption
    {
        // Motivos Isenção
        public string Id { get; set; } // Codigo
      //  public string Codigo { get; set; }
        public string MencaoFatura { get; set; }
        public int CodigoTaxaId { get; set; } = 2; 
        public int TipoTaxaId { get; set; } = 2;
        public virtual TaxType TipoTaxa { get; set; }

        public bool RegimeGeral { get; set; } = true;
        public bool RegimeSimplificado { get; set; } = false;
        public bool RegimeExclusao { get; set; } = false;
        public bool flagPrincipal { get; set; } = true;
        public virtual TaxCode CodigoTaxa { get; set; }
    }
}
