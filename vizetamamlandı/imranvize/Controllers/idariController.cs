using imranvize.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace imranvize.Controllers
{

   
    public class idariController : Controller
    {
        okulEntities2 db = new okulEntities2();

        public ActionResult Index()
        {
            var degerler = db.idari.ToList();
            return View(degerler);
        }
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult Yeniidari()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeniidari(idari p1)
        {
            db.idari.Add(p1);
            db.SaveChanges();
            return View();
        }



        public ActionResult SIL(int id)
        {
            var idi = db.idari.Find(id);
            db.idari.Remove(idi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult idariguncelle(int id)
        {
            var ogr = db.idari.Find(id);
            return View("idariguncelle", ogr);
        }
        
        public ActionResult Guncelle(idari p1)
        {
            var ktg = db.idari.Find(p1.idariid);
            ktg.idariadsoyad = p1.idariadsoyad;
            ktg.idariunvan = p1.idariunvan;
            ktg.idaribasla = p1.idaribasla;
            ktg.idaricıkıs = p1.idaricıkıs;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
