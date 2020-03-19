using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtify
{
    class Spotify_User
    {
        public string display_name { get; set; }

        public object external_urls { get; set; }

        public object followers { get; set; }

        public string href { get; set; }

        public string id { get; set; }

        public object images { get; set; }

        public string type { get; set; }

        public string uri { get; set; }
    }
}
