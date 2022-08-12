using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace tatilSeyahat.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<adresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> İletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }



    }
}