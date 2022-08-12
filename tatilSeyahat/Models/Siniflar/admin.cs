using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tatilSeyahat.Models.Siniflar
{
    public class admin
    {

        [Key]
        public int Id { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }

    }
}