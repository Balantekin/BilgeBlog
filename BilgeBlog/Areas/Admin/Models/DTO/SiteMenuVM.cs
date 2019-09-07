using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilgeBlog.Areas.Admin.Models.DTO
{
    public class SiteMenuVM:BaseVM
    {
        [Required]
        public string Name { get; set; }
        public string URL { get; set; }

        public string cssClass { get; set; }
    }
}