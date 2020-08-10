using MusicStoreApi.Repositories;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class UserServices : GeneralServices<UserRepository>, IUserServices
    {
        private readonly IUserRepository _musicRepository;
        public UserServices(IUserRepository userRepository, Repository<UserRepository> table) : base(table)
        {
            _musicRepository = userRepository;
        }
    }
}
