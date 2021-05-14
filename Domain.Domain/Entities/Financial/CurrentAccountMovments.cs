using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Financial
{
    public class CurrentAccountMovments
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int CurrentAccountFromId { get; set; }
        public int CurrentAccountDestinId { get; set; }
        public string TipoMovimentoId { get; set; } // Transferência, Deposito, pagamento
        public decimal SaldoTransferido { get; set; }
        public int UserId { get; set; }  // Usuário que fez o movimento

        public virtual CurrentAccountSystem CurrentAccountFrom { get; set; }
        public virtual CurrentAccountSystem CurrentAccountDestin { get; set; }
        public virtual MovmentType MovementType { get; set; }
        public virtual User User { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
