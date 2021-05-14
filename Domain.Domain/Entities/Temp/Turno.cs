 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Temp
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataF { get; set; }
        public string Hora { get; set; }
        public string HoraF { get; set; }
        public string Estado { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserName { get; set; }
        public decimal Caixa { get; set; }
        public decimal Abertura { get; set; }
        public decimal Tpa { get; set; }

    }
}
