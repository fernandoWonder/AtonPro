namespace Infrastructure.Data.Migrations
{
    using Domain.Domain.Entities;
    using Initializer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true; // Permite atualizar a base de dados mesmo que haja perda de dados
        }

        protected override void Seed(Context.ContextDB context)
        {
            User userStandard = DataSystemInitializer.getUserStandard()[0];
            if (context.User.Where(q => (q.Usuario == userStandard.Usuario && q.KeySenha == userStandard.KeySenha)).Count() == 0)
                DataSystemInitializer.getUserStandard().ForEach(c => context.User.AddOrUpdate(c)); // Cadastra o usuario master

            if (context.TaxReasonExemption.ToList().Count == 0)
            {
                context.CurrentAccountSystem.AddOrUpdate(DataSystemInitializer.getCurrentAccount());
                DataSystemInitializer.getFormasPagamento().ForEach(paymenteMechanism => context.PaymentMechanism.AddOrUpdate(paymenteMechanism));
                DataSystemInitializer.getConfigCurrentAccount().ForEach( c => context.ConfigCurrentAccount.AddOrUpdate(c));
                DataSystemInitializer.getMovmentsType().ForEach(movmentType => context.MovmentType.AddOrUpdate(movmentType));
                DataSystemInitializer.getSystemEntities().ForEach(c => context.SystemEntities.AddOrUpdate(c));
                context.SystemInfo.AddOrUpdate(DataSystemInitializer.getSystemInfo());
                DataSystemInitializer.getCompanyTypes().ForEach(c => context.CompanyType.AddOrUpdate(c));
                DataSystemInitializer.getCompanyInit().ForEach(c => context.Company.AddOrUpdate(c));

                DataSystemInitializer.getFamiles().ForEach(family => context.Family.AddOrUpdate(family)); // Cadastra as familias

                DataSystemInitializer.getTiposTaxas().ForEach(tipoTaxa => context.TaxType.AddOrUpdate(tipoTaxa)); // Cadastra os Tipos de taxa
                DataSystemInitializer.getCodigosTaxa().ForEach(codTaxa => context.TaxCode.AddOrUpdate(codTaxa)); // Cadastra os códigos de taxa
                DataSystemInitializer.getMotivoIsencao().ForEach(motivoISE => context.TaxReasonExemption.AddOrUpdate(motivoISE)); // Cadastra os motivo Isenção
                DataSystemInitializer.getInvoiceType().ForEach(iType => context.InvoiceType.AddOrUpdate(iType)); // Cadastra os tipos de fatura
                DataSystemInitializer.getRazoesNota().ForEach(c => context.NoteReason.AddOrUpdate(c));              // Cadastra as razões da nota de credito ou debito
                DataSystemInitializer.getTipoDeOprecaoNota().ForEach(c => context.NoteOperatioType.AddOrUpdate(c));  // Cadastra as operações da nota de credito ou debito
                DataSystemInitializer.getInvoiceStatus().ForEach(iStatus => context.InvoiceStatus.AddOrUpdate(iStatus)); // Cadastra status de fatura
                DataSystemInitializer.getTipoProduto().ForEach(tipoProduto => context.ProductType.AddOrUpdate(tipoProduto));
                DataSystemInitializer.getUnidade().ForEach(unidade => context.BaseUnit.AddOrUpdate(unidade));
                DataSystemInitializer.getCountry().ForEach(country => context.Country.AddOrUpdate(country));
                DataSystemInitializer.getCity().ForEach(city => context.City.AddOrUpdate(city));
                context.Category.AddOrUpdate(DataSystemInitializer.getCagory());
                context.Customer.AddOrUpdate(DataSystemInitializer.getFinalCustimer());

            }
                
        }
    }
}
