using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Entities
{
    public class Music
    {
        public int MusicId { get; set; }
        public String MusicName { get; set; }
        public DateTime MusicReleaseDate { get; set; }
        public int SingerId { get; set; }
        public Singer Singer { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
