using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class Series
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public DateTime AnoInicio { get; set; }
        public DateTime AnoTermino { get; set; }
        public virtual ICollection<Invoice> Faturas { get; set; }
        public bool FlagState { get; set; } = true;
        public DateTime DataCadastro { get; set; }
    }
}
