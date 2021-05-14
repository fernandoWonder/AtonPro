using System;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
       // public bool FlagStandard { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}