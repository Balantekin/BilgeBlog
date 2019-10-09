using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Controllers
{
    public class SiteHomeController : Controller
    {
        // GET: SiteHome
        public ActionResult Index()
        {
            return View();
        }
    }
}