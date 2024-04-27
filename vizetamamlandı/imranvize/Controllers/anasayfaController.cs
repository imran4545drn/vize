using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imranvize.Models.entity;

namespace imranvize.Controllers
{
    public class anasayfaController : Controller
    {

        okulEntities2 db = new okulEntities2();

        public ActionResult Index()
        {


            var degerler = db.Ogretmen.ToList();
                return View(degerler);
            }
        [HttpGet]
        public ActionResult Yeniogretmen()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Yeniogretmen(Ogretmen p1)
        {
            db.Ogretmen.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var ogretmen = db.Ogretmen.Find(id);
            db.Ogretmen.Remove(ogretmen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Ogretmenguncelle(int id)
        {
            var ogr = db.Ogretmen.Find(id);
            return View("Ogretmenguncelle", ogr);
        }
        public ActionResult Guncelle(Ogretmen p1)
        {
            var ktg = db.Ogretmen.Find(p1.ogretmenid);
            ktg.ogretmenad = p1.ogretmenad;
            ktg.ogretmensoyad = p1.ogretmensoyad;
            ktg.ogretmengiris = p1.ogretmengiris;
            ktg.ogretmencıkıs = p1.ogretmencıkıs;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
    
}
