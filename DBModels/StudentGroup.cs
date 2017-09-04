using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class StudentGroup
    {
        public int StudentGroupID { get; set; }

        public int StudentID { get; set; }
        public int GroupID { get; set; }

        public virtual Group Group { get; set; }
        public virtual Student Student { get; set; }

    }
}
