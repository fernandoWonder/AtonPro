using System;

namespace Domain.Domain.Entities.ProductStock
{
    public class Storage
    {
        public int Id { get; set; }
        public string Armazem { get; set; }
        public string Descricao { get; set; }
        public bool FlagState { get; set; }
        public DateTime DataCadastro { get; set; }
     //   public virtual ICollaction<Stock> stocks { get; set; } 
    }
}
