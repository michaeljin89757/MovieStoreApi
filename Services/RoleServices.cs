using MusicStoreApi.Repositories;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class RoleServices : GeneralServices<RoleRepository>, IRoleServices
    {
        private readonly IRoleRepository _roleRepository;
        public RoleServices(IRoleRepository roleRepository, Repository<RoleRepository> table) : base(table)
        {
            _roleRepository = roleRepository;
        }
    }
}
