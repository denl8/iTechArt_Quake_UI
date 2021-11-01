using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArt_Quake_UI.Data.Models
{
    public class Map
    {
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string Poster { set; get; }
        public int MaxPlayers { set; get; }
    }
}
