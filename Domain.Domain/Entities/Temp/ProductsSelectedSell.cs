using Domain.Domain.Entities.ProductStock;

namespace Domain.Domain.Entities.Temp
{
    public class ProductsSelectedSell
    {
        public int Id { get; set; }
       
        public int StockId { get; set; }
        public int ProdutoId { get; set; }
        public string DescricaoProduto
        {
            get
            {
                return Produto.Descricao;
            }
        }
        public decimal Preco { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorDesconto
        {
            get
            {
                return PrecoQdade * Desconto / 100;
            }
        }
        public decimal PrecoQdade
        {
            get
            {
                return Preco * Quantidade;
            }
        }

        public decimal Taxa
        {
            get
            {
                return Produto.CodigoTaxa.Taxa;
            }
        }
        public decimal TotalIncidencia
        {
            get
            {
                return PrecoQdade - ValorDesconto;
            }
        }
        public decimal TotalTaxa
        {
            get
            {
                return (Produto.CodigoTaxa.Taxa * TotalIncidencia / 100);
            }
        }
        public decimal Total
        {
            get
            {
                return (TotalIncidencia + TotalTaxa);
            }
        }
        public virtual Product Produto { get; set; }
        public virtual Stock Stock { get; set; }

    }
}
