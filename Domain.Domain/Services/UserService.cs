using Domain.Domain.Entities;
using Domain.Domain.Interfaces.Repositories;
using Domain.Domain.Interfaces.Services;

namespace Domain.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) :base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
