﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Gameofthrones.Models;

namespace Gameofthrones.Controllers
{
    public class GOTcontroller : Controller
    {
        public ActionResult Detail()
        {
            var GameOfThrones = new EpisodeSet()
            {
                EpisodeTitle = "Winter Is Coming",
            };

            ViewBag.SeriesTitle = "Winter Is Coming";
            ViewBag.EpisodeSeason = 0001;
            ViewBag.EpisodeNumber = 0001;
            ViewBag.Description = "<p>Jon Arryn, the Hand of the King, is dead. King Robert Baratheon plans to ask his oldest friend, Eddard Stark, to take Jon's place. Across the sea, Viserys Targaryen plans to wed his sister to a nomadic warlord in exchange for an army.</p>";
            ViewBag.Credits = new string[]
            {
                    "Directed by Timothy Van Patten  ... (as Tim Van Patten)",
                    "Writing Credits, " +
                    " David Benioff   ... (created by)",
                    "D.B. Weiss  ... (created by)",
                    "George R.R. Martin  ... (based on 'A Song of Ice and Fire' by)",
                    "David Benioff   ... (written by)",
                    "D.B. Weiss  ... (written by)"
            };
                          
            return View(GameOfThrones);
            
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
