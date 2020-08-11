using MusicStoreApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services.ServiceInterfaces
{
    public interface ISingerServices
    {
        Task<IEnumerable<Singer>> ListAllSingers();
    }
}
