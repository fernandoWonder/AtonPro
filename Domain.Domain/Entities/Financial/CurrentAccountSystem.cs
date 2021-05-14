
using System;

namespace Domain.Domain.Entities.Financial
{
    public class CurrentAccountSystem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string NumeroConta { get; set; } // unic
        public int? BankId { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoAbertura { get; set; }
        public DateTime? DataSaldoVerificada { get; set; }
        public bool Opened { get; set; } = false;
        public bool FlagState { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
