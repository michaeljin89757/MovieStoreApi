using MusicStoreApi.Repositories;
using MusicStoreApi.Repositories.RepositoryInterfaces;
using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Services
{
    public class GenreServices : GeneralServices<GenreRepository>, IGenreServices
    {
        private readonly IGenreRepository _genreRepository;
        public GenreServices(IGenreRepository genreRepository, Repository<GenreRepository> table) : base(table)
        {
            _genreRepository = genreRepository;
        }
    }
}
