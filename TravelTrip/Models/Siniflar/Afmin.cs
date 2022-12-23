using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Afmin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public string sifre { get; set; }
    }
}