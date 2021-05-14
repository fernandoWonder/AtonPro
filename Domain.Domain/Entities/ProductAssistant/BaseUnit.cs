using System;

namespace Domain.Domain.Entities.ProductAssistant
{
    public class BaseUnit
    {
        public int Id { get; set; }
        public string Simbolo { get; set; }
        public string Unidade { get; set; }
        public bool FlagState { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}