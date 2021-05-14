using System;

namespace Domain.Domain.Entities.Assistants
{
    public class City
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public int PaisId { get; set; }
        public Country Pais { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
