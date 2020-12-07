using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Proje.Entities.Interfaces;

namespace Proje.Entities.Concrete
{
    public class Work : ITablo
    {
       
        public int Id { get; set; }

        public string Ad { get; set; }
        public string Aciklamasi { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
