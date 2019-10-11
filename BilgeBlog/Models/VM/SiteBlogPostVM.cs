using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.VM
{
    public class SiteBlogPostVM:SiteBaseVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string PostImagePath { get; set; }
        public string Category { get; set; }
        public DateTime AddTime { get; set; }
        



    }
}