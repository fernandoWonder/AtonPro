using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Entities.ProductStock;
using System;

namespace Domain.Domain.Entities.Documents
{
    public class ProductSales
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public string Descricao_Produto { get; set; }
        public int ProductId { get; set; }
        public int StockId { get; set; }
        public decimal Preco { get; set; }
        public decimal Taxa { get; set; }
        public string MotivoISEId { get; set; }
        public virtual TaxReasonExemption MotivoISE { get; set; }
        public string MotivoIsencao { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorDesconto
        {
            get
            {
                return (Preco * Quantidade) * Desconto / 100;
            }
        }
        public string Unidade { get; set; }
        public decimal Quantidade { get; set; }
        public decimal TotalIncidencia
        {
            get
            {
                return (Preco * Quantidade) - ValorDesconto ;
            }
        }
        public decimal TotalTaxa {
            get
            {
                return (Taxa * TotalIncidencia / 100);
            }
        }
        public decimal Total {
            get
            {
                return (TotalIncidencia + TotalTaxa);
            }
        }
        public string Observacao { get; set; }

        public virtual Invoice Fatura { get; set; }
        public virtual Product Product { get; set; }
        public virtual Stock Stock { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
