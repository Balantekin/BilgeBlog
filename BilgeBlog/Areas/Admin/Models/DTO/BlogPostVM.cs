using System;
using System.Collections.Generic;
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
        public IEnumerable<SelectListItem> DropdownCategories { get; set; }


    }
}