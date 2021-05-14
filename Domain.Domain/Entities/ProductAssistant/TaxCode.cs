using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class TaxCode
    {
        // Aqui Entrará as taxas : NOR - 14, ISE
        public int Id { get; set; }
        public decimal Taxa{ get; set; }
        public string Code { get; set; }
        public string Descricao { get; set; }
        public int TipoTaxaId { get; set; } = 1; // IVA
        public bool flagPrincipal { get; set; } = true;
        public virtual TaxType TipoTaxa { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}