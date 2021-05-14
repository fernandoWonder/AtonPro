using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class Composition
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Composicao { get; set; }
        public virtual Product Produto { get; set; }
        public virtual ICollection<CompositionProducts> Produtos_Copmposicao { get; set; }
        /*
            Contem os produtos que têm composição

            Um produto pode ter varias composições porem cada composição deve ter um nome ou descrição Exemplo para Humburguer (comps.1 -> Humb. Grande | comp.2 Humb. pequeno)
            e dentro dessas composições têm os produtos que os compõesm
        */

        public DateTime DataCadastro { get; set; }
    }
}