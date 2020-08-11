using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        //protected readonly ApiDbContext _dbContext;
        public GenreRepository(ApiDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }
    }
}
