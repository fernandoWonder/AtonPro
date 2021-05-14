using System;
using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Infrastructure.Data.Initializer;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public int insertUser(User user)
        {
            user.KeySenha = Security.ConstantsPasswordKey.GetRandomPasswordKey();
            user.Senha = Security.Crypto.EncryptStringAES(user.Senha, user.KeySenha);
            return insert(user);
        }

        public int updateWithChangePassWord(User user)
        {
            user.KeySenha = Security.ConstantsPasswordKey.GetRandomPasswordKey();
            user.Senha = Security.Crypto.EncryptStringAES(user.Senha, user.KeySenha);
            return update(user);
        }

        public int userFirstLoginUpdate(User user)
        {
            user.FlagFirstLogin = false;
            user.KeySenha = Security.ConstantsPasswordKey.GetRandomPasswordKey();
            user.Senha = Security.Crypto.EncryptStringAES(user.Senha, user.KeySenha);
            return update(user);
        }

        public User login(string nome, string senha)
        {
            var user = _contextDB.User.Where(c => c.Usuario.ToString() == nome).FirstOrDefault();
            if (user == null)
                return null;
            string senhaDeciptada = Security.Crypto.DecryptStringAES(user.Senha, user.KeySenha);

            return  (senhaDeciptada == senha) ? user : null;
        }

        public User userRecovered(string email)
        {
            var user = _contextDB.User.Where(c => c.Usuario == email).FirstOrDefault();
            return (user != null) ? user : null;
        }

        public int LastId()
        {
            return _contextDB.User.Last().Id;
        }

        public object view1(string search)
        {
            search = search.ToLower();
            var query = from u in _contextDB.User.Where(c => c.FlagState && !c.FlagStandard && (c.Usuario.Contains(search) ||
                        c.Id.ToString().Contains(search)) )
                        select new { u.Id, u.Usuario, u.Nome, u.Bi, u.Sexo, u.DataNascimento, u.Endereco, u.Email, u.Tel, u.DataCadastro};

            return query.ToList();
        }
        public object view2(string search)
        {
            search = search.ToLower();
            var query = from u in _contextDB.User.Where(c => c.FlagState && !c.FlagStandard && (c.Usuario.Contains(search) ||
                        c.Id.ToString().Contains(search)))
                        select new { u.Id, u.Usuario, u.Nome, u.Bi, u.Sexo, u.DataNascimento, u.Endereco, u.Email, u.Tel, };

            return query.ToList();
        }

    }
}
