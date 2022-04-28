using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace testingproject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/bun-Js-jquery").Include(
                "~/Scripts/jquery-3.6.0.js",
                "~/Scripts/bootstrap.bundle.js"
                ));
            BundleTable.EnableOptimizations = true;
        }
    }
}