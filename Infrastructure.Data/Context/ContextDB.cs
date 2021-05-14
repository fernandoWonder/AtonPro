using Domain.Domain.Entities;
using Domain.Domain.Entities.Assistants;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Entities.Temp;
using Infrastructure.Data.Config;
using Infrastructure.Data.Initializer;
using Infrastructure.Data.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Context
{
    public class ContextDB : DbContext
    {
       
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSellectedTable> ProductSellectedTable { get; set; }
        
        public DbSet<Company> Company { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Family> Family { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<FamilyRest> FamilyRest { get; set; }
        public DbSet<SystemInfo> SystemInfo { get; set; }
        // Assistants
        public DbSet<SystemEntities> SystemEntities { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<CompanyType> CompanyType { get; set; }
        // 
        // Documents
        public DbSet<ConfigCurrentAccount> ConfigCurrentAccount { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatus { get; set; }
        public DbSet<InvoiceType> InvoiceType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Recibo> Recibo { get; set; }
        public DbSet<PaymentsRecibos> PaymentsRecibos { get; set; }
        public DbSet<PaymentMechanism> PaymentMechanism { get; set; }
        public DbSet<ProductEntry> ProductEntry { get; set; }
        public DbSet<ProductRetreat> ProductRetreat { get; set; }
        public DbSet<ProductSales> ProductSales { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<InvoiceNoteReason> NoteReason { get; set; }
        public DbSet<InvoiceNoteOperationType> NoteOperatioType { get; set; }
        //
        //Financial
        public DbSet<Bank> Bank { get; set; }
        public DbSet<MovmentType> MovmentType { get; set; }
        public DbSet<CurrentAccountMovments> CurrentAccountMovments { get; set; }
        public DbSet<CurrentAccountSystem> CurrentAccountSystem { get; set; }
        //
        // P. Assistants
        public DbSet<BaseUnit> BaseUnit { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Composition> Composition { get; set; }
        public DbSet<CompositionProducts> CompositionProducts { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<TaxReasonExemption> TaxReasonExemption { get; set; }
        public DbSet<TaxCode> TaxCode { get; set; }
        public DbSet<TaxType> TaxType { get; set; }
        //
        //P.Stock
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Table> Table { set; get; }
        //
        // Temp
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet<Printer> Printer { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<ProductsSelectedSell> ProductsSelectedSell { get; set; }
        //
        bool ambienteProducao = false; // Mudar Para True Quando Tudo Terminarou Quando For Para Produção
        public ContextDB() : base(CompanyConnection.ConectionDefault)/*base(CompanyConnection.ConectionCompany)/**/
        {
            if(ambienteProducao)
                Database.SetInitializer<ContextDB>(new ContextDBInitializerProduction());
            else
                Database.SetInitializer<ContextDB>(new ContextDBInitializerDevelopment());
            Database.SetInitializer<ContextDB>(new MigrateDatabaseToLatestVersion<ContextDB, Configuration>());
           // Database.SetInitializer<ContextDB>(new DropCreateDatabaseAlways<ContextDB>());
        }

        private class ContextDBInitializerDevelopment: DropCreateDatabaseIfModelChanges<ContextDB>
        {

        }

        private class ContextDBInitializerProduction : CreateDatabaseIfNotExists<ContextDB>
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            /* Desabilita o auto Incremet nos IDs
            modelBuilder.Properties().Where(c => c.Name.ToLower().Equals("id")).Configure(c => c.IsKey().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None));
            */

            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("nome")).Configure(c => c.HasMaxLength(200));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("descricao")).Configure(c => c.HasMaxLength(400));

            //modelBuilder.Properties<int>().Where(c => c.Name.Contains("Id")).Configure(c => c.IsOptional());
            
            //modelBuilder.Properties<bool>().Where(c => c.Name.ToLower().Contains("flagState")).Configure(c => c.HasColumnAnnotation("Default Value or Binding = True", c));
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("senha")).Configure(c => c.HasMaxLength(1200));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("email")).Configure(c => c.HasMaxLength(200));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("sexo")).Configure(c => c.HasMaxLength(1));
            modelBuilder.Properties().Where(c => c.Name.ToLower().Contains("hash")).Configure(c => c.HasMaxLength(1200));

            modelBuilder.Configurations.Add(new TaxCodeMap());
            modelBuilder.Configurations.Add(new TaxReasonExemptionMap());
            modelBuilder.Configurations.Add(new InvoiceTypeMap());
            modelBuilder.Configurations.Add(new PaymentMechanismMap());

           // modelBuilder.Configurations.Add(new  UserMap());

            base.OnModelCreating(modelBuilder);
        }

        // Esta função apesar de não ser chamada resolve o erro de dependencia do Entity - In Ohter Words don`t need add more EF into UI-Project
        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public override int SaveChanges()
        {
            
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                bool IsInvoice = false;

                DateTime d = Convert.ToDateTime(entry.Property("DataCadastro").CurrentValue);

                if (d.Year != 0001)
                    IsInvoice = true;

                if (entry.State == EntityState.Added && !IsInvoice /*&&  entry.Property("DataCadastro").CurrentValue == null*/)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now; // Coloca o valor da data atual para datacCadastro ao ccadastrar elementos
                }
                 if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false; // Não muda a data de cadastro de um elemento
                /*else 
                if (entry.State == EntityState.Added && entry.Property("DataCadastro").CurrentValue != null)
                    if(entry.Property("DataCadastro").CurrentValue.ToString().Length < 5)
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;*/
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("FlagState") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("FlagState").CurrentValue = true; // Coloca o valor da data atual para datacCadastro ao ccadastrar elementos
            }
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch(DbUnexpectedValidationException e)
            {
                Console.WriteLine("\nEntity errors: ", e.Message);
                throw;
            }
            catch(DbUpdateException e)
            {
                Console.WriteLine("\nEntity errors: ", e.ToString());

                return 0;
            }
            
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
