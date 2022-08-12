using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tatilSeyahat.Models.Siniflar;

namespace tatilSeyahat.Controllers
{
    public class IletisimController : Controller
    {

        Context c = new Context();

        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult IletisimSil(int id)
        {
            var deger = c.İletisims.Find(id);
            c.İletisims.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Iletisim","Admin");
        }
    }
}