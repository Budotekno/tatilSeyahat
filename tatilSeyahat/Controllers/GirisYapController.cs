using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using tatilSeyahat.Models.Siniflar;

namespace tatilSeyahat.Controllers
{
    public class GirisYapController : Controller
    {
        Context C = new Context(); 

        // GET: GirisYap
        public ActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Login(admin ad)
        {
            var bilgiler = C.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["KullaniciAdi"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");


            }

            else
            {
                ViewBag.yanlıs = "Hatalı giriş yaptınız. Lütfen tekrar deneyiniz!";
                return View();

            }

           
        }

        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");

        }


    }
}