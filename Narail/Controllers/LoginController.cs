using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Narail.Models;

namespace Narail.Controllers
{
    public class LoginController : Controller
    {
        NarailDBEntities db = new NarailDBEntities();
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Author p)
        {
            var bilgiler = db.Author.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Mail"] = bilgiler.Email.ToString();
                //    TempData["Ad"] = bilgiler.ad.ToString();
                //    TempData["ID"] = bilgiler.id.ToString();
                //    TempData["Soyad"] = bilgiler.soyad.ToString();
                //    TempData["KullanıcıAdı"] = bilgiler.kullaniciadi.ToString();
                //    TempData["Sifre"] = bilgiler.sifre.ToString();
                //    TempData["Okul"] = bilgiler.okul.ToString();

                return View();
            }
            else
            {
                
                return RedirectToAction("Index", "AuthorAdmin");
            }

        }


    }
}