using MusicStoreApi.Repositories;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class SingerServices : GeneralServices<SingerRepository>, ISingerServices 
    {
        private readonly ISingerRepository _singerRepository;
        public SingerServices(ISingerRepository singerRepository, Repository<SingerRepository> table) : base(table)
        {
            _singerRepository = singerRepository;
        }
    }
}
