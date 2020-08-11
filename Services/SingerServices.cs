using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class SingerServices : ISingerServices
    {
        private readonly ISingerRepository _singerRepository;

        public SingerServices(ISingerRepository singerRepository)
        {

            _singerRepository = singerRepository;
        }
        public async Task<IEnumerable<Singer>> ListAllSingers()
        {
            return await _singerRepository.ListAllAsync();
        }
    }
}
