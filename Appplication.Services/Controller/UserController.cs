using Domain.Domain.Entities;
using Infrastructure.Data.Repositories;
using System.Collections.Generic;

namespace Appplication.Controller
{
    public class UserController
    {
        protected UserRepository _userRepository = new UserRepository();

        public int salvar(User user)
        {
            return _userRepository.insertUser(user);
        }

        public int update(User user)
        {
            return _userRepository.update(user);
        }
        public User getLast()
        {
            return _userRepository.getLast();
        }
        public int LogOf(User user)
        {
            user.FlagLogado = false;
            return update(user);
        }

        public int updateWithChangePassWord(User user)
        { // Atualiza quando a senha é alterada e criptografa antes de a inserir
            return _userRepository.updateWithChangePassWord(user);
        }

        public int deletar(User user)
        {
            return _userRepository.remove(user);
        }
        public void Dispose()
        {
            _userRepository.Dispose();
        }
        public User getOne(int id)
        {
            return _userRepository.listForID(id);
        }

        public int userFirstLoginUpdate(User user)
        {
            return _userRepository.userFirstLoginUpdate(user);
        }

        public List<User> ListAllAsNotracking()
        {
            return _userRepository.ListAllAsNoTracking();
        }

        public User Logar(string user, string senha)
        {  
            User us = _userRepository.login(user, senha);
            if(us != null)
            {
                us.FlagLogado = true;
                update(us);
                Dispose();
            }
            return us;
        }
        public User verify(string user, string senha)
        {
            User us = _userRepository.login(user, senha);
           
            return us;
        }

        public int LastId()
        {
            return _userRepository.LastId();
        }

        public object view(string search)
        {
            return _userRepository.view1(search);
        }
        public object view2(string search)
        {
            return _userRepository.view2(search);
        }

    }
}
