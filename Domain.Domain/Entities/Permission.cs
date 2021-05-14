using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class Permission
    { 
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual User Usuario { get; set; }
        public bool Stock { get; set; }
        public bool Venda { get; set; }
    }
}
