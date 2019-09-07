using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BilgeBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/admin/layout").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/jquery.easing.min.js",
                "~/Scripts/sb-admin-2.min.js"

                ));

            bundles.Add(new StyleBundle("~/bundles/admin/layoutstyles").Include(
                "~/Areas/Admin/Content/css/all.min.css",
                "~/Areas/Admin/Content/css/sb-admin-2.css"

                ));



        }
    }
}