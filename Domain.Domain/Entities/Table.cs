using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class Table
    {
        
        public Table() { }
        public int Id { get; set; }
        public string Mesa { get; set; }
        public object Image { get; set; }
        public virtual ICollection<ProductSellectedTable> productsSellectedTable { get; set; }

    }
}
