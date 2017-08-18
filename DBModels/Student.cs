using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class Student
    {
        public int StudentID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Pesel { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }

        public int AddressID { get; set; }
        public int ClassroomID { get; set; }
        public int UserID { get; set; }
        public int TimetableID { get; set; }

    }
}
