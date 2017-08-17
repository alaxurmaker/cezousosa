using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Subject_teacher
    {
        public int Subject_teacherID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}