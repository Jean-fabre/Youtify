using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtify
{
    class Spotify_All_Playlists
    {
        public string Href { get; set; }

        public List<Spotify_Playlist> Items { get; set; }

        public string Limit { get; set; }
        public string Next { get; set; }
        public string Offset { get; set; }
        public string Previous { get; set; }
        public string Total { get; set; }
    }
}
