using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BilgeBlog.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly BlogContext db = new BlogContext();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                if(db.AdminUsers.Any(x=>x.Email==model.Email&&x.Password==model.Password&&x.IsDeleted==false))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}