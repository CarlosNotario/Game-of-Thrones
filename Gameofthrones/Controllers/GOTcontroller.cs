using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameofthrones.Controllers
{
    public class GOTcontroller : Controller
    {
        public ActionResult Details()
        {
            if (DateTime.Today.DayOfWeek==DayOfWeek.Sunday)
            {
                return Redirect("/");
            }
            return Content("What would you like to know about Game of Thrones?");

        }
    }
}