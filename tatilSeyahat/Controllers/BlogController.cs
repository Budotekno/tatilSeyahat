using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using tatilSeyahat.Models.Siniflar;

namespace tatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();

        // GET: Blog
        public ActionResult Index()
        {
            //var degerler = c.Blogs.ToList();
            by.blog = c.Blogs.ToList();
            by.yorum = c.Yorumlars.ToList();
            by.blogListe = c.Blogs.OrderByDescending(x=>x.Id).Take(5).ToList() ;
            by.yorumListe = c.Yorumlars.OrderByDescending(x => x.Id).Take(5).ToList();
            return View(by);
        }


        //Blog detay sayfası
      
        public ActionResult BlogDetay(int id)
        {
            
            by.blog = c.Blogs.Where(x=>x.Id==id).ToList();
            by.yorum = c.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(by);

        }

        [HttpGet]
        public PartialViewResult YorumYap(int Id)
        {
            ViewBag.tasinanId = Id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}