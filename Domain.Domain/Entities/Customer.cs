using Domain.Domain.Entities.Assistants;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Conta_Corrente { get; set; }
        public string Cliente { get; set; }
        public string Nif { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade {
            get
            {
                //int year = int.Parse(DateTime.Compare(DateTime.Now, DataNascimento).ToString("yyyy"));
                return DateTime.Now.Subtract(DataNascimento).Days / 365;
            }
        }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Endereco { get; set; }
        public string Postal { get; set; }
        public int CidadeId { get; set; }

        public virtual City Cidade { get; set; }
        public virtual ICollection<Invoice> Faturas { get; set; }
        

        public DateTime DataCadastro { get; set; }
    }
}
