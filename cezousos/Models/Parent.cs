using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Parent
    {
        public int ParentID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Numer_telefonu { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}