using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Entities
{
    public class Singer
    {
        public int SingerId { get; set; }
        public String SingerName { get; set; }
        public String SingerNationality { get; set; }
        public IEnumerable<Music> Musics { get; set; }
    }
}
