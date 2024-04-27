using imranvize.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace imranvize.Controllers
{
    public class HomeController : Controller
    {
        public okulEntities2 db = new okulEntities2();
        public ActionResult Giris()
        {
            return View();
        }

        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}