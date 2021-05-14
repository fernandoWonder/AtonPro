using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;

namespace Domain.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string KeySenha { get; set; }

        public string Bi { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get
            {
                return DateTime.Now.Subtract(DataNascimento).Days / 365;
            }
        }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Endereco { get; set; }
        public int? CidadeId { get; set; }
        public bool FlagFirstLogin { get; set; } = true;
        public bool FlagStandard { get; set; } = false;
        public bool FlagAdmin { get; set; } = false;
        public bool FlagState { get; set; } = true;
        public bool FlagLogado { get; set; } = false;
        public DateTime? DataCadastro { get; set; }

        public virtual List<Invoice> Faturas { get; set; }

    }
}
