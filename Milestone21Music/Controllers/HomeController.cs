using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milestone21Music.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Rhythmn.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact details can be found below:";

            return View();
        }

        public ActionResult BedroomProudcerDiaries()
        {
            return View();
        }

        public ActionResult Music()
        {
            //this method takes the user to the music page with iframes of various soundclouds links.

            return View();
        }
    }
}