using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class CompositionProducts
    {
        public int Id { get; set; }
        public int ComposicaoId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public string Descricao { get; set; }
        public virtual Product Produto { get; set; }
        public virtual Composition Composicao { get; set; }
        public DateTime DataCadastro { get; set; }
        /*
            Esta tabela contem os produtos de composições / produtos que compõem outros produtos
            ou seja se um produto tem composição, os produtos dessa composição estarão aqui

            A descrição é apenas para dizer o que aquele produto faz na composição (Eg.: Maionese - > Da um sabor epico e gostoso ao humburger))
        */
    }
}
