using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public String GenreName { get; set; }
        public IEnumerable<Music> Musics { get; set; }
    }
}
