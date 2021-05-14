using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities.Documents
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string InvoiceNo { get; set; }
        public int SeriesId { get; set; }
        public string TipoDocumentoId { get; set; }
        public int ClienteId { get; set; }
        public int? FornecedorId { get; set; }
        public int UserId { get; set; }
        public string FormaPagamentoId { get; set; }
        public decimal Desconto { get; set; } // Soma dos descontos
        public decimal TotalIncidencia { get; set; }
        public DateTime? DataVencimento { get; set; }
        public decimal TotalLiquidar { get; set; } // Caso seja Fatura
        public decimal TotalGeral
        {
            get
            {
                return TotalIncidencia + TotalImposto;
            }
        }

      /*  public decimal TotalLiquidadar
        {
            get
            {
                decimal tot = 0;
                foreach (var item in Pagamentos)
                {
                    tot += item.ValorPago;
                }
                return tot;
            }
        }*/

        public decimal TotalImposto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public string Observacao { get; set; }
        public string Hash { get; set; }
        public string HashPositions
        {
            get
            {
                return Hash.Length > 0 ? Hash.Substring(0, 1) + Hash.Substring(9, 1) + Hash.Substring(19, 1) + Hash.Substring(29, 1) + "-Processado por programa validado n31.1/AGT20 SellerPro" : "Sem hash";
            }
        }
        public string InvoiceDate { get; set; }
        public int InvoiceStatusId { get; set; } = 1; // 1 - Normal

        // Para notas de credito
        public string Referencia { get; set; }
        public string RazaoNota { get; set; }
        public int? TipoOperacaoId { get; set; }
        public decimal Debito { get; set; }

        public virtual InvoiceNoteOperationType TipoOperacao { get; set; }

        // »»»»»»»»»»»»»»»»»»»»»»»»
        public virtual Series Series { get; set; }
        public virtual InvoiceType TipoDocumento { get; set; }
        public virtual Customer Cliente { get; set; }
        public virtual Provider Fornecedor { get; set; }
        public virtual User User { get; set; }
        public virtual PaymentMechanism FormaPagamento { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
        public virtual ICollection<ProductSales> ProductsSales { get; set; }
        //public virtual ICollection<Recibo> Recibos { get; set; }
        public virtual ICollection<PaymentsRecibos> Pagamentos { get; set; }
        public bool FlagState { get; set; }
        public bool OriginalFeita { get; set; } = false;
        public bool Corrigido { get; set; } = false;
        public DateTime DataCadastro { get; set; }

    }
}
