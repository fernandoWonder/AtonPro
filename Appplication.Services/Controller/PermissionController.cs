using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Controller
{
   public class PermissionController
    {
        PermissionRep _permissionController = new PermissionRep();

        public List<Permission> ListALL()
        {
            return _permissionController.ListAll();
        }
        public Permission listForId(int id)
        {
            return _permissionController.listForID(id) ;
        }

        public Permission getForIdUser(int idUser)
        {
            return _permissionController.getForIdUser(idUser);
        }

        public List<Permission> ListALLAsNoTracking()
        {
            return _permissionController.ListAllAsNoTracking();
        }
        public Permission getOne(int id)
        {
            return _permissionController.listForID(id);
        }


        public int insert(Permission Permission)
        {
            return _permissionController.insert(Permission);
        }

        public int delete(Permission Permission)
        {
            return _permissionController.remove(Permission);
        }

        public int update(Permission Permission)
        {
            return _permissionController.update(Permission);
        }
       
        public int removeForId(int id)
        {
            return _permissionController.removeForID(id);
        }
    }
}
