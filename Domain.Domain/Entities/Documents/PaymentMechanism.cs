using System;

namespace Domain.Domain.Entities.Documents
{
    public class PaymentMechanism
    {
        public string Id { get; set; }
    //    public string FormaPagamento { get; set; }
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
