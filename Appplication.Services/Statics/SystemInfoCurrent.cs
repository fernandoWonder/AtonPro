using Appplication.Controller;
using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;

namespace Appplication.Statics
{
    public static class SystemInfoCurrent
    {
        static Company company;
        public static SystemInfo SystemInfo;
        public static void initialize()
        {
            SystemInfoRepository stInfoRepo = new SystemInfoRepository();
            SystemInfo = stInfoRepo.ListAll()[0];
            company = new CompanyController().ListALL()[0];
        }

        public static Company getCurrentCompany()
        {
            return company;
        }

        public static void setCurrentCompany(Company cp)
        {
            company = cp;
        }

    }
}
