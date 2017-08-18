using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class Classroom
    {
        public int ClassroomID { get; set; }

        public string Name { get; set; }
        public int AgeGroup { get; set; }
        public string Profile { get; set; }
        public int Amount { get; set; }

        public int EducatorID { get; set; }
   
    }
}
