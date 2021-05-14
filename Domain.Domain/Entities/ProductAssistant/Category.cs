using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class Category
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Product> produtos  { get; set; }
    }
}