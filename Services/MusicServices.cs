using MusicStoreApi.Entities;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class MusicServices : IMusicServices
    {
        private readonly IMusicRepository _musicRepository;

        public MusicServices(IMusicRepository musicRepository)
        {

            _musicRepository = musicRepository;
        }

        public async Task<IEnumerable<Music>> ListAllMusic()
        {
            return await _musicRepository.ListAllAsync();
        }
    }
}
