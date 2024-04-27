using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imranvize.Models.entity;

namespace imranvize.Controllers
{
    public class OgrenciController : Controller
    {
        
        okulEntities2 db = new okulEntities2();
        public ActionResult Index()
        {
            var degerler = db.Ogrenci.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniogrenci()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Yeniogrenci(Ogrenci p1)
        {
            db.Ogrenci.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var ogrenci = db.Ogrenci.Find(id);
            db.Ogrenci.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ogrenciguncelle(int id)
        {
            var ogr = db.Ogrenci.Find(id);
            return View("ogrenciguncelle", ogr);
        }
        public ActionResult Guncelle(Ogrenci p1)
        {
            var ktg = db.Ogrenci.Find(p1.ogrenciid);
            ktg.ogrenciad = p1.ogrenciad;
            ktg.ogrencisoyad = p1.ogrencisoyad;
            ktg.ogrencikredi = p1.ogrencikredi;
            ktg.ogrencigiris = p1.ogrencigiris;
            ktg.ogrencicıkıs = p1.ogrencicıkıs;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}