using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Models.DTO
{
    public class BlogPostVM:BaseVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        [Display(Name = "Ana Resim")]
        public HttpPostedFileBase PostImage { get; set; }
        public IEnumerable<SelectListItem> DropdownCategories { get; set; }


    }
}