using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imranvize.Models.entity;

namespace imranvize.Controllers
{
    public class RaporController : Controller
    {
        okulEntities2 db = new okulEntities2();
        public ActionResult rapor()
        {
            ViewModel model = new ViewModel();
            model.ogrencis = db.Ogrenci.ToList();
            model.Ogretmens = db.Ogretmen.ToList();
            model.idaris = db.idari.ToList();
            return View(model);

        }
      
    

    }
}
