using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.ORM.Entity;
using BilgeBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Controllers
{
    public class SiteBlogController : SiteBaseController
    {
        // GET: SiteBlog
        public ActionResult Index(int id)
        {
            Blog blog = db.Blogs.FirstOrDefault(x => x.ID == id);
            SiteBlogPostVM model = new SiteBlogPostVM();
            model.Content = blog.Content;
            model.Title = blog.Title;
            model.PostImagePath = blog.ImagePath;
            model.Category = blog.Category.CategoryName;


            return View(model);
        }
    }
}