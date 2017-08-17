using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Nazwa { get; set; }
        public string Tresc_ksztalcenia { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Subject_teacher> Subject_teachers { get; set; }

    }
}