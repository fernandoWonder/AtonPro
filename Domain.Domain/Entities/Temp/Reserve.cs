using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Temp
{
    public class Reserve
    {
        public Reserve()
        {

        }
        public virtual Table Mesa { get; set; }
        public int Id { get; set; }

        public int MesaId { get; set; } 
 
        public string Cliente
        {
            get; set;
        }
        public string DataMarcada { get; set; }
        public string Data { set; get; }
        public string Hora { get; set; }
        public int  IdClient{set;get;}
        
        public string Contacto { get; set; }
        public string Observacoes { get; set; }
    }
}
