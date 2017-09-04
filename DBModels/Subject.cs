using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GradeRating> GradeRatings { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
