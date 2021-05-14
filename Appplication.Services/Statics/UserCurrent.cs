using Appplication.Controller;
using Domain.Domain.Entities;

namespace Appplication.Statics
{
    public static class UserCurrent
    {
        static User userLogado;
        static Permission permission;

        public static void initialize(User user)
        {
            userLogado = user;
        }
        public static Permission getPermission()
        {
          return new PermissionController().getForIdUser(userLogado.Id); 
        }

        public static User getCurrentUser()
        {
            return userLogado;
        }

        public static void logOf()
        {
            UserController _usController = new UserController();
            _usController.LogOf(userLogado);
        }

    }
}
