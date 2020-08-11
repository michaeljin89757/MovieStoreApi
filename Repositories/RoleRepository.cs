using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        // readonly ApiDbContext _dbContext;
        public RoleRepository(ApiDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }
    }
}
