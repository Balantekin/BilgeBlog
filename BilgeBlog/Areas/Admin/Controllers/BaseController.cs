using BilgeBlog.Areas.Admin.Models.Attributes;
using BilgeBlog.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    [LoginControl]
    public class BaseController : Controller
    {
        public BlogContext db;
        public BaseController()
        {
            db = new BlogContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

    }
}