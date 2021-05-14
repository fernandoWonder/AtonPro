using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class PaymentsRecibos
    {

        public int Id { get; set; }
        public int ReciboId { get; set; }
        public decimal ValorPago { get; set; }
        public int FaturaId { get; set; }  // Id da fatura de linha - Fatura liquidada
        public string Descricao { get; set; }
        public decimal Taxa { get; set; } // Se na fatura tiver um produto com taxa, aparecera aqui a percentagem dessa taxa
        
        public virtual Invoice Fatura { get; set; }
        public virtual Recibo Recibo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
