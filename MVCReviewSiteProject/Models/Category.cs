using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string System { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}