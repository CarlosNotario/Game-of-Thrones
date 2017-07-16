using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameOfThrones2.Models;

namespace GameOfThrones2.Controllers
{
    public class GOTcontroller : Controller
    {
        public ActionResult Detail()
        {
            List<EpisodeSet> GameOfThrones;
            using (var context = new GOTDbContext())

                GameOfThrones = context.EpisodeSets.ToList();
            //    Season=1,
            //    EpisodeNumber=1,
            //    EpisodeTitle="Winter is Coming",
            //    Description="White walkers",

            //};

            //ViewBag.SeriesTitle = "Winter Is Coming";
            //ViewBag.EpisodeSeason = 0001;
            //ViewBag.EpisodeNumber = 0001;
            //ViewBag.Description = "<p>Jon Arryn, the Hand of the King, is dead. King Robert Baratheon plans to ask his oldest friend, Eddard Stark, to take Jon's place. Across the sea, Viserys Targaryen plans to wed his sister to a nomadic warlord in exchange for an army.</p>";
            //ViewBag.Credits = new string[]
            //{
            //        "Directed by Timothy Van Patten  ... (as Tim Van Patten)",
            //        "Writing Credits, " +
            //        " David Benioff   ... (created by)",
            //        "D.B. Weiss  ... (created by)",
            //        "George R.R. Martin  ... (based on 'A Song of Ice and Fire' by)",
            //        "David Benioff   ... (written by)",
            //        "D.B. Weiss  ... (written by)"
            //};

            return View(GameOfThrones.First());

        }

        private static GOTDbContext GetContext(GOTDbContext context)
        {
            return context;
        }
        /*private Task <HttpResponseMessage> getEpisode()
{
   var Client = new HttpClient();
   return Client.GetAsync("http://www.omdbapi.com/?apikey=[yourkey]&");

}
private Task<HttpResponseMessage> getPoster()
{
   var Client = new HttpClient();
   return Client.GetAsync("http://img.omdbapi.com/?apikey=[yourkey]&");
}*/
    }
}