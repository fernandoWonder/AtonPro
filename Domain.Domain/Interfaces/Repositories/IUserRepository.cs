using Domain.Domain.Entities;
using System;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User login(string nome, string senha);
        int insertUser(User user);
        User userRecovered(string email);

        object view1(string search);
        object view2(string search);

    }
}
