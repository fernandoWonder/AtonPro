using Domain.Domain.Entities.ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Documents
{
    public class ProductRetreat
    {
        public int Id { get; set; }
        public int ArmazemId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public string Motivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Storage Armazem { get; set; }
        public virtual Product Produto { get; set; }
    }
}
