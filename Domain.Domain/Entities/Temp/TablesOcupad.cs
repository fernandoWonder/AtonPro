using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Temp
{
    public class TablesOcupad
    {
        public int id { get; set; }
        public string table { get; set; }

        
        TablesOcupad()
        {

        }
        public TablesOcupad(int id,string table)
        {
            this.id = id;
            this.table = table;
        }
    }
}
