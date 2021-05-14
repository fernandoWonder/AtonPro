using Domain.Domain.Entities.ProductAssistant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Drawing;


namespace Domain.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Codigo_Barra { get; set; }
        public string Descricao { get; set; }
        public string Descricao2 { get; set; }
        public decimal Preco1 { get; set; }
        public decimal Preco1CIVA {
            get { return (Preco1 * (1 + CodigoTaxa.Taxa / 100)); }
        }
        public decimal? Preco2 { get; set; }
        public decimal? Preco3 { get; set; }
        public int? CategoriaId { get; set; }
        public int? UnidadeBaseId { get; set; }
        public int TipoArtigoId { get; set; } // Produto acabado ou serviço
        //public int TaxaImpostod { get; set; }
        public bool Move_Stock { get; set; } // Se afeta ou não o stock
        public DateTime? DataExpiracao { get; set; }
        public string MotivoISEId { get; set; }
        public int? FornecdorId { get; set; } // Será guardado id dos fornecedor separados por ;
        public bool FlagState { get; set; }
        public int CodigoTaxaId { get; set; }

        public virtual TaxCode CodigoTaxa { get; set; }
        public virtual Category Categoria { get; set; }
        public virtual ProductType TipoArtigo { get; set; }
        public virtual BaseUnit UnidadeBase { get; set; }
        // public virtual TaxCode TaxaImposto { get; set; }
        public virtual TaxReasonExemption MotivoISE { get; set; }
        public virtual Provider Fornecdor { get; set; }

        
        public string UrlImg { get; set; }
        public DateTime DataCadastro { get; set; }
        public object image { get; set; }
        
        //  public virtual ICollection<Composition> Composicoes { get; set; }

    }
}
