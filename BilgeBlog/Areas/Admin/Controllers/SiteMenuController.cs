using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    public class SiteMenuController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSiteMenu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSiteMenu(SiteMenuVM model)
        {
            if(ModelState.IsValid)
            {
                SiteMenu siteMenu = new SiteMenu();
                siteMenu.Name = model.Name;
                siteMenu.URL = model.URL;
                siteMenu.cssClass = model.cssClass;

                db.SiteMenus.Add(siteMenu);
                db.SaveChanges();

                ViewBag.islemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
            

            
        }

        public ActionResult AddSiteMenuWithJSON()
        {
            return View();
        }

        public JsonResult AddSiteMenuJSON(SiteMenuVM model)
        {
            SiteMenu siteMenu = new SiteMenu();
            siteMenu.Name = model.Name;
            siteMenu.URL = model.URL;
            siteMenu.cssClass = model.cssClass;

            db.SiteMenus.Add(siteMenu);
            db.SaveChanges();

            return Json("");
        }
    }
}