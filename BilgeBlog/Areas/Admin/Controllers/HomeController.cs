using BilgeBlog.Areas.Admin.Models.Attributes;
using BilgeBlog.Models.ORM.Context;
using BilgeBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    [LoginControl]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [Authorize]
        public ActionResult Index()
        {
            //kullanıcı ad ve soyadı login olduktan sonra email adresi ile yakaladık

            BlogContext db = new BlogContext();
            string email = System.Web.HttpContext.Current.User.Identity.Name;
            AdminUser adminUser = db.AdminUsers.FirstOrDefault(x => x.Email == email);
            string name = adminUser.Name;
            string surname = adminUser.Surname;

            return View();
        }
    }
}