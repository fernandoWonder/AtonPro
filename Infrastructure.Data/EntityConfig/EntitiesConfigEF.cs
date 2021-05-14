
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductAssistant;
using System.Data.Entity.ModelConfiguration;

namespace Infrastructure.Data.Config
{
    // EntityTypeConfiguration - Where will be created all MapClasses for Entity Configurations That will be used for 
    // DbContext on method OnModelCreating(DbModelBuilder modelBuilder)
    // Eg.: modelbuilder.Configuration().Add(new ClassMAp);
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
           // this.HasKey(c => c.Id);
        }
    }

    public class TaxCodeMap : EntityTypeConfiguration<TaxCode>
    {
        public TaxCodeMap()
        {
            this.HasKey(c => c.Id) ;
        }
    }

    public class TaxReasonExemptionMap : EntityTypeConfiguration<TaxReasonExemption>
    {
        public TaxReasonExemptionMap()
        {
            this.Property(c => c.MencaoFatura).HasMaxLength(200);
        }
    }

    public class PaymentMechanismMap : EntityTypeConfiguration<PaymentMechanism>
    {
        public PaymentMechanismMap()
        {
            this.HasKey(c => c.Id);
        }
    }

    public class InvoiceTypeMap : EntityTypeConfiguration<InvoiceType>
    {
        public InvoiceTypeMap()
        {
            HasKey(c => c.Id);
        }
    }

}
