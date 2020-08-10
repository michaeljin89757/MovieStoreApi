using MusicStoreApi.Repositories;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class MusicServices : GeneralServices<MusicRepository>, IMusicServices
    {
        private readonly IMusicRepository _musicRepository;

        public MusicServices(IMusicRepository musicRepository, Repository<MusicRepository> table) : base(table)
        {

            _musicRepository = musicRepository;
        }
    }
}
