using imranvize.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imranvize
{
    public class ViewModel
    {
        public List<Ogrenci> ogrencis { get; set; }
        public List<Ogretmen> Ogretmens { get; set; }

        public List<idari> idaris { get; set; }
       
    }
}