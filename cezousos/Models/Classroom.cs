using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Classroom
    {
        public int ClassroomID { get; set; }
        public int TeacherID { get; set; } //gdy wychowawca

        public string Nazwa { get; set; }
        public string Profil { get; set; }
        public virtual List<Subject> Subjects { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}