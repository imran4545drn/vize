using imranvize.Models.entity;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace imranvize.Controllers
{
    public class GuvenlikController : Controller
    {
        okulEntities2 db = new okulEntities2();

        [HttpGet]
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(admin kullanici)

        {
            var kullaniciInDb = db.admin.FirstOrDefault(x => x.ad == kullanici.ad && x.sifre == kullanici.sifre);
            if (kullaniciInDb != null)
            {
                FormsAuthentication.SetAuthCookie(kullaniciInDb.ad, false);
                return RedirectToAction("Index", "idari");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı adı veya şifre";
                return View();
            }
        }
            public ActionResult Cıkıs()

        {
            FormsAuthentication.SignOut();
            return RedirectToAction("giris");

        }


    }
}