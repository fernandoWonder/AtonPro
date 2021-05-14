using Domain.Domain.Entities.ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.Temp
{
    public class ProductSellectedTable
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public Table Mesa { get; set; }
        public int StockId { get; set; }
        public string data { get; set; }
        public int ProdutoId { get; set; }
       
        public decimal Preco { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Desconto { get; set; }
      
        
       
        
        
        public virtual Product Produto { get; set; }
        public virtual Stock Stock { get; set; }
        public ProductSellectedTable()
        {

        }
        public string productoName { get; set; }
    }
}
