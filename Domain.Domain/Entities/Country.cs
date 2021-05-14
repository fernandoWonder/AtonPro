using Domain.Domain.Entities.Assistants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<City> Cidades { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
