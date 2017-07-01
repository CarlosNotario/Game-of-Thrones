using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameofthrones.Controllers
{
    public class GOTcontroller : Controller
    {
        public ActionResult Detail
        {

            get
            {
                return View();
            }
        }
    }
}