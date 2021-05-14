using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class Family
    {
        public int Id { get; set; }
        public string family { get; set; }
        public virtual ICollection<FamilyRest> familias  { get;set; }
    }
}
