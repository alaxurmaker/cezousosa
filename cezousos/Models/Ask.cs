using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Zapytanie
    {
        [ScaffoldColumn(false)]
        public int ZapytanieID { get; set; }

        public int TeacherID { get; set; }

        [DataType(DataType.MultilineText)]
        public string Tresc { get; set; }
        public string Odpowiedz { get; set; }

        private DateTime? dateCreated;
        [ScaffoldColumn(false)]
        public DateTime DateCreated
        {
            get { return dateCreated ?? DateTime.Now; }
            set { dateCreated = value; }
        }

        public virtual Teacher Teacher { get; set; }
    }
}