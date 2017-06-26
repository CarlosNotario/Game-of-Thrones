using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameofthrones.Controllers
{
    public class GOTcontroller : Controller
    {
        public ContentResult Details()
        {
            return new ContentResult()
            {
                    Content = "What would you like to know about Game of Thrones?"
            };
        }
    }
}