using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gameofthrones.Models
{
    public class EpisodeSet
    {
        public int Id { get; set; }
        public string EpisodeTitle { get; internal set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Description { get; set; }
        
    }
}
/*public string SeriesTitle { get; set; }*/

