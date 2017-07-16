using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfThrones2.Models
{
    public class EpisodeSet
    {
        public int Id { get; set; }
        public string EpisodeTitle { get; set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Description { get; set; }

    }
}