﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
   public class ClassroomTimetable
    {
        public int ClassroomTimetableID { get; set; }

        public int Time { get; set; }
        public int Day { get; set; }

        public int RoomID { get; set; }
        public int ClassroomID { get; set; }

    }
}
