using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.ProductStock
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal MinStock { get; set; }
        public decimal MaxStock { get; set; }
        public decimal UltimoPreco { get; set; }
        public decimal PrecoMedio { get; set; }
        public int ArmazemId { get; set; }
        public virtual Product Produto { get; set; }
        public virtual Storage Armazem { get; set; }
        public DateTime DataCadastro { get; set; }



    }
}
