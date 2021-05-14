using System;

namespace Domain.Domain.Entities.Financial
{
    public class Bank
    {
        public int Id { get; set; }
        public string Banco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
