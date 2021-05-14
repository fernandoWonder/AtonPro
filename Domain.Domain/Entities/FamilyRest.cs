using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class FamilyRest
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Product Producto { get; set; }
        public int FamiliaId { get; set; }
        public Family Familia { get; set; }
 
    }
}
