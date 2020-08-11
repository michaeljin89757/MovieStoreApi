using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class SingerRepository : Repository<Singer>, ISingerRepository
    {
        //protected readonly ApiDbContext _dbContext;
        public SingerRepository(ApiDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }
    }
}
