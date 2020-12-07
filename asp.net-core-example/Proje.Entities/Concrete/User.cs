using Proje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Entities.Concrete
{
    public class User : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyadı { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public List<Work> Works { get; set; }

    }
}
