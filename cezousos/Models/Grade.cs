using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public int Ocena { get; set; }
        public DateTime Data_wystawienia { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}