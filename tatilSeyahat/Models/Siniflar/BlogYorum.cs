using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace tatilSeyahat.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> blog { get; set; }
        public IEnumerable<Blog> blogListe { get; set; }
        public IEnumerable<Yorumlar> yorum { get; set; }
        public IEnumerable<Yorumlar> yorumListe { get; set; }
    }
}