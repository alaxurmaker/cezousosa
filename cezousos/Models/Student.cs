using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public int ClassroomID { get; set; }
        public int ParentID { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ulica { get; set; }
        public string Miejscowosc { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public DateTime Data_rozpoczecia { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }

    }
}