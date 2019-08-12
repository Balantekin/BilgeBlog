using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class Category:BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Blog> Blogs { get; set; }



    }
}