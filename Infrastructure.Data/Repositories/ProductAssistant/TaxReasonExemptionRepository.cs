using System;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Interfaces.Repositories.ProductAssistant;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductAssistant
{
    public class TaxReasonExemptionRepository : BaseRepository<TaxReasonExemption>, ITaxReasonExemption
    {
        
    }
}
