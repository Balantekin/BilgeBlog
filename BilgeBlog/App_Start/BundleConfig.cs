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
                "~/Areas/Admin/Content/vendor/fontawesome-free/css/all.min.css",
                "~/Areas/Admin/Content/css/sb-admin-2.css"

                ));


        }
        public static void SiteBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/site/layout").Include(
                "~/Scripts/SiteScripts/jquery.min.js",
                "~/Scripts/SiteScripts/clean-blog.min.js",
                "~/Scripts/SiteScripts/bootstrap.bundle.js",
                "~/Scripts/jqBootstrapValidation.js",
                "~/Scripts/contact_me.js"


                ));

            bundles.Add(new StyleBundle("~/bundles/site/layoutstyles").Include(
                "~/Content/vendor/fontawesome-free/css/all.min.css",
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/clean-blog.min.css"


                ));
        }

              
      
    }
}