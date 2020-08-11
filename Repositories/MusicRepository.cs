using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        //protected readonly ApiDbContext _dbContext;
        public MusicRepository(ApiDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }
    }
}
