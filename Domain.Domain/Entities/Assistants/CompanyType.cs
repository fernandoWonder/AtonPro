using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Assistants
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
        /*tipos: Regime Geral; Não Sujeição; Transitório; etc.*/
    }
}
