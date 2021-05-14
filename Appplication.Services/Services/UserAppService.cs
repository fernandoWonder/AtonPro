using Appplication.Services.Interfaces.Services;
using Domain.Domain.Entities;
using Domain.Domain.Services;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces.Services;

namespace Appplication.Services.Services
{
    public class UserAppService : BaseAppService<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService) : base(userService)
        {
            _userService = userService;
        }
    }
}

