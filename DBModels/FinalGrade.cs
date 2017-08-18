using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class FinalGrade
    {
        public int FinalGradeID { get; set; }

        public int Value { get; set; }
        public string TextValue { get; set; }
        public string ConductGrade { get; set; }
        public string Note { get; set; }

        public int StudentGradeID { get; set; }
        public int SeasonID { get; set; }
    }
}
