using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Subject_teacher> Subject_teachers { get; set; }
    }
}