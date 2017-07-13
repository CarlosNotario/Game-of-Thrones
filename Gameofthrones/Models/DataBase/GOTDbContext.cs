using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gameofthrones.Models.DataBase
{
    public class GOTDbContext : DbContext
    {
        public DbSet<EpisodeSet> Episodes { get; set; }
        public GOTDbContext() : base("SeedEpisodes.sql") { }
    }
}