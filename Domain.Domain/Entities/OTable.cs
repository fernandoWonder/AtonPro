using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    class OTable
    {
        public string mesa { get; set; }
        public object image { get; set; }
        public OTable(string mesa)
        {
            this.mesa = mesa;
        }
    }
}
