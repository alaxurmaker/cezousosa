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
        public int StudentGroupID { get; set; }
        public int SubjectID { get; set; }
    }
}
