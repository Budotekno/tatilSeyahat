using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tatilSeyahat.Models.Siniflar;

namespace tatilSeyahat.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();      

        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }

        [Authorize]
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);         
            c.SaveChanges();
            return RedirectToAction("Index");
         
        }

        [Authorize]
        public ActionResult Sil(int id)
        {
            var bululanId = c.Blogs.Find(id);
            c.Blogs.Remove(bululanId);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bulunanId = c.Blogs.Find(id);
            return View("BlogGetir",bulunanId);
        }

        [Authorize]
        public ActionResult Guncelle(Blog b)
        {
            var degerler = c.Blogs.Find(b.Id);
            degerler.Baslik = b.Baslik;
            degerler.Aciklama = b.Aciklama;
            degerler.Tarih = b.Tarih;
            degerler.FotoUrl = b.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        [Authorize]
        public ActionResult Yorumlistesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);

        }

        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var bulunanId = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(bulunanId);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }


        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var bulunanId = c.Yorumlars.Find(id);
            return View("YorumGetir",bulunanId);
        }

        [Authorize]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var degerler = c.Yorumlars.Find(y.Id);
            degerler.KullaniciAdi = y.KullaniciAdi;
            degerler.Mail = y.Mail;
            degerler.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }


        [Authorize]
        public ActionResult Hakkimizda()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult Iletisim()
        {
            var degerler = c.İletisims.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult HakkimdaGuncelle(Hakkimizda h)
        {
            h.Id = 1;
            var degerler = c.Hakkimizdas.Find(h.Id);
            degerler.Aciklama = h.Aciklama;
            degerler.FotoUrl = h.FotoUrl;
            c.SaveChanges();

            return RedirectToAction("Hakkimizda");
        }

        [Authorize]
        public ActionResult IletisimEkle(iletisim i)
        {
            c.İletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index", "Iletisim");
        }

        [Authorize]
        public ActionResult Admin() 
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult AdminEkleSayfasi()
        {
            return View();
        }

        [Authorize]
        public ActionResult AdminEkle(admin a)
        {
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }

        [Authorize]
        public ActionResult AdminSil(int id)
        {
            var deger = c.Admins.Find(id);
            c.Admins.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Admin");

        }

        [Authorize]
        public ActionResult AdminGetir(int id)
        {
            var deger = c.Admins.Find(id);            
            return View(deger);
        }

        [Authorize]
        public ActionResult AdminGuncelle(admin a)
        {
            var deger = c.Admins.Find(a.Id);
            deger.Kullanici = a.Kullanici;
            deger.Sifre = a.Sifre;
            c.SaveChanges();
            return RedirectToAction("Admin");
        }

    }
}