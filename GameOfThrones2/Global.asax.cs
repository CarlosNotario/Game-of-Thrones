using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GameOfThrones2.Models;

namespace GameOfThrones2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer<GOTDbContext>(new DropCreateDatabaseAlways<GOTDbContext>());
            using (var DB = new GOTDbContext())
            {
                var Episode = new EpisodeSet();
                Episode.EpisodeTitle = "Winter Is Coming";
                Episode.Season = 1;
                Episode.EpisodeNumber = 1;
                Episode.Description = "Jon Arryn, the Hand of the King, is dead. King Robert Baratheon plans to ask his oldest friend, Eddard Stark, to take Jon''s place. Across the sea, Viserys Targaryen plans to wed his sister to a nomadic warlord in exchange for an army.";
                DB.EpisodeSets.Add(Episode);
                Episode = new EpisodeSet();
                Episode.EpisodeTitle = "The Kingsroad";
                Episode.Season = 1;
                Episode.EpisodeNumber = 2;
                Episode.Description = "While Bran recovers from his fall, Ned takes only his daughters to King''s Landing. Jon Snow goes with his uncle Benjen to the Wall. Tyrion joins them.";
                DB.EpisodeSets.Add(Episode);
                Episode = new EpisodeSet();
                Episode.EpisodeTitle = "Winter Is Coming";
                Episode.Season = 1;
                Episode.EpisodeNumber = 3;
                Episode.Description = "Lord Stark and his daughters arrive at King''s Landing to discover the intrigues of the king''s realm.";
                DB.EpisodeSets.Add(Episode);
                Episode = new EpisodeSet();
                Episode.EpisodeTitle = "Cripples, Bastards, and Broken Things";
                Episode.Season = 1;
                Episode.EpisodeNumber = 4;
                Episode.Description = "Eddard investigates Jon Arryn''s murder. Jon befriends Samwell Tarly, a coward who has come to join the Night''s Watch";
                DB.EpisodeSets.Add(Episode);
                Episode = new EpisodeSet();
                Episode.EpisodeTitle = "The Wolf and the Lion";
                Episode.Season = 1;
                Episode.EpisodeNumber = 5;
                Episode.Description = "Catelyn has captured Tyrion and plans to bring him to her sister, Lysa Arryn, at the Vale, to be tried for his, supposed, crimes against Bran. Robert plans to have Daenerys killed, but Eddard refuses to be a part of it and quits.";
                DB.EpisodeSets.Add(Episode);

                DB.SaveChanges();
            }
        }
    }
}
