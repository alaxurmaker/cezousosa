using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
   public class GroupTimetable
    {
        public int GroupTimetableID { get; set; }

        public int Time { get; set; }
        public int Day { get; set; }

        public int RoomID { get; set; }
        public int GroupID { get; set; }

        public virtual Room Room { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
