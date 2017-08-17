using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models
{
    public class Post
    {
        [ScaffoldColumn(false)]
        public int PostID { get; set; }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        private DateTime? dateCreated;
        [ScaffoldColumn(false)]
        public DateTime DateCreated
        {
            get { return dateCreated ?? DateTime.Now; }
            set { dateCreated = value; }
        }
    }
}