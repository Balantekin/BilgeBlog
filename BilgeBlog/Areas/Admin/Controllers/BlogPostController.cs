using BilgeBlog.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    public class BlogPostController : BaseController
    {
        // GET: Admin/BlogPost
        public ActionResult AddBlogPost()
        {
            BlogPostVM model = new BlogPostVM();
            model.DropdownCategories = db.Categories.Select(x => new SelectListItem()
            {
                Text =x.CategoryName,
                Value=x.ID.ToString()

              }).ToList();

            return View(model);
                      

        }
        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }


    }
}