using BilgeBlog.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Models.Services.HTMLDataSourceServices
{
    public class DropDownServices
    {
        public static IEnumerable<SelectListItem> getDropDownCategories()
        {
            using(BlogContext db=new BlogContext())
            {
                IEnumerable<SelectListItem> drpCategories = db.Categories.Select(x => new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.ID.ToString()

                }).ToList();

                return drpCategories;
            }
            
        }
    }
}