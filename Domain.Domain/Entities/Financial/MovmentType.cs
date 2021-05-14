using System;

namespace Domain.Domain.Entities.Financial
{
    public class MovmentType
    {
        public string Id { get; set; }
        public string TipoMovimento { get; set; } // Transferência, Deposito
        public DateTime DataCadastro { get; set; }
    }
}
