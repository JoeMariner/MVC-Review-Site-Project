using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        public string NameOfGame { get; set; }
        public string ReviewedBy { get; set; }
        public int YearPublished { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }

        [ForeignKey("Category")]
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}