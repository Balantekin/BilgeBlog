using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Controllers
{
    public class SiteHomeController : SiteBaseController
    {
        // GET: SiteHome
        public ActionResult Index()
        {
            List<SiteBlogPostVM> model = db.Blogs.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new SiteBlogPostVM()
            {
                Title = x.Title,
                Category = x.Category.CategoryName,
                AddTime=x.AddDate,
                ID=x.ID
                


            }).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}