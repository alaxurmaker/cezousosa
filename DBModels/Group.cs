using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
   public class Group
    {
        public int GroupID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public int TeacherID { get; set; }
        public int SubjectID { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<GroupTimetable> GroupTimetables { get; set; }
        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
