using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GameOfThrones2.Models;

namespace GameOfThrones2
{
    public class GOTDbContext : DbContext
    {
        public DbSet<EpisodeSet> EpisodeSets { get; set; }

        public GOTDbContext() : base("Episodes")
        {

        }
    }
}