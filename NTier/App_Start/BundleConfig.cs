using System.Globalization;
using System.Web;
using System.Web.Optimization;
using System.Threading;

namespace NTier
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            string bootstrapJs;
            if (System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft)
                bootstrapJs = "~/Scripts/bootstrap-rtl.js";
            else
                bootstrapJs = "~/Scripts/bootstrap.js";

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      bootstrapJs,
                      "~/Scripts/respond.js" ,
                      "~/Scripts/moment.js",
                      "~/Scripts/moment-with-locales.js",
                      "~/Scripts/bootstrap-datetimepicker.js" ,
                      "~/Scripts/jquery-override.js"

                      ));
            string bootstrapCss;
            if (Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft)
                bootstrapCss = "~/Content/css/bootstrap-rtl.css";
            else
               bootstrapCss = "~/Content/bootstrap.css";
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      bootstrapCss,
                      "~/Content/Site.css" ,
                      "~/Content/bootstrap-datetimepicker.css"
                      ));
        }
    }
}
