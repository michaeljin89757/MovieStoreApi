using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        protected readonly ApiDbContext _dbContext;
        public UserRepository(ApiDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
