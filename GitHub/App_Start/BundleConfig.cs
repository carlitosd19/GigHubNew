﻿using System.Web.Optimization;

namespace GitHub
{
    public class BundleConfig
    {
        private const string VirtualPathCSS = "~/Content/css";
        private const string ExternalLibs = "~/bundles/lib";

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/scripts/app/services/attendanceService.js",
                        "~/scripts/app/services/followingService.js",
                        "~/scripts/app/controllers/gigsController.js",
                        "~/scripts/app/controllers/gigDetailsController.js",
                        "~/scripts/app/app.js"
                ));
                

            bundles.Add(new ScriptBundle(ExternalLibs).Include(
                       "~/Scripts/jquery-{version}.js",
                        "~/Scripts/underscore-min.js",
                        "~/Scripts/moment.min.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.min.js",
                        "~/Scripts/respond.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle(VirtualPathCSS).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/animate.css"));
        }
    }
}
