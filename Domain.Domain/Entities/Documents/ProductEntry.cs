using Domain.Domain.Entities.Financial;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities.Documents
{
    public class ProductEntry
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal Taxa { get; set; }
        public decimal PrecoTotal { get; set; }
        public int FornecedorId { get; set; }
        public string FormaPagamentoId { get; set; }
        public int ContaDebitadaId { get; set; }
        public string MovementTypeId { get; set; } = "3"; // Pagamento

        /* Utilizar esses elementos quando utilizarmos controle de Lotes
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
        */
        public virtual Product Produto { get; set; }
        public virtual Provider Fornecedor { get; set; }
        public virtual PaymentMechanism FormaPagamento { get; set; }
        public virtual CurrentAccountSystem ContaDebitada { get; set; }
        public virtual MovmentType MovementType { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
