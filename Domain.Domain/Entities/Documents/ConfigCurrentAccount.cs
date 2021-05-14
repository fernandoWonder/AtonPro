using Domain.Domain.Entities.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class ConfigCurrentAccount
    {
        public int Id { get; set; }
        public string PaymentMechanismId { get; set; }
        public int CurrentAccountId { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual CurrentAccountSystem CurrentAccount { get; set; }
        public virtual PaymentMechanism PaymentMechanism { get; set; }

    }
}
