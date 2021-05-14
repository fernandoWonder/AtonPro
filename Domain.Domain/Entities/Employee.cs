
using Domain.Domain.Entities.Assistants;
using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public string Bi { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Endereco { get; set; }
        public int CidadeId { get; set; }
        public virtual City Cidade { get; set; }
        public virtual ICollection<Invoice> Faturas { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
