using Domain.Domain.Entities.Documents;
using Infrastructure.Data.Repositories.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
    public class ConfigCurrentAccountController
    {
        ConfigCurrentAccountRepository _configCurrentAccountRepo = new ConfigCurrentAccountRepository();

        public List<ConfigCurrentAccount> ListALL()
        {
            return _configCurrentAccountRepo.ListAll();
        }

        public List<ConfigCurrentAccount> ListALLAsNoTracking()
        {
            return _configCurrentAccountRepo.ListAllAsNoTracking();
        }

        public List<ConfigCurrentAccount> ListForUserId(int userId)
        {
            return _configCurrentAccountRepo.ListAll().Where(c => c.UserId == userId).ToList();
        }

        public ConfigCurrentAccount ListForUserIdPaymentId(int userId, string paymentWayId)
        {
            return _configCurrentAccountRepo.ListAll().Where(c => c.UserId == userId && c.PaymentMechanismId == paymentWayId).FirstOrDefault();
        }

        public ConfigCurrentAccount getOne(int id)
        {
            return _configCurrentAccountRepo.listForID(id);
        }
        public ConfigCurrentAccount getForPaymentId(string paymentId)
        {
            return _configCurrentAccountRepo.ListAll().Where(c => c.PaymentMechanismId == paymentId).FirstOrDefault();
        }

        public int insert(ConfigCurrentAccount configCurrentAccount)
        {
            return _configCurrentAccountRepo.insert(configCurrentAccount);
        }

        public int delete(ConfigCurrentAccount configCurrentAccount)
        {
            return _configCurrentAccountRepo.remove(configCurrentAccount);
        }

        public int update(ConfigCurrentAccount configCurrentAccount)
        {
            return _configCurrentAccountRepo.update(configCurrentAccount);
        }

        public int deleteFoId(int id)
        {
            return _configCurrentAccountRepo.removeForID(id);
        }

        public void Dispose()
        {
            _configCurrentAccountRepo.Dispose();
        }

    }
}
