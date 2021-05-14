using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities.Documents
{
    public class Recibo
    {
        public int Id { get; set; }
        public int DocumentoId { get; set; }

        public decimal TotalRecibo { get; set; }
        public int EstadoDocumentoId { get; set; } = 1; // 1 - Normal // Estado do documento

        public string RazaoAlteracaoEstado { get; set; }
        public int UserUltimoEstadoDocumentoId { get; set; } // Usuário responsável pelo ultimo estado do documento

        public virtual Invoice Documento { get; set; }
        public virtual User UserUltimoEstadoDocumento { get; set; }
        public virtual InvoiceStatus EstadoDocumento { get; set; }
        public DateTime DataUltimoEstadoPagamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<PaymentsRecibos> Payments { get; set; }
    }
}
