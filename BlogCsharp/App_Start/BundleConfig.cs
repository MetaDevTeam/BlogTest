using System.Web;
using System.Web.Optimization;

namespace BlogCsharp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
          

            bundles.Add(new ScriptBundle("~/bundles/main-scripts").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.js"


                      ));

            bundles.Add(new ScriptBundle("~/bundles/fancybox").Include(
          "~/Scripts/bootstrap.js",
          "~/Scripts/bootstrap.js",
          "~/Scripts/bootstrap.js",
          "~/Scripts/bootstrap.js",
          "~/Scripts/bootstrap.js"



          ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/common.css",
                      "~/Content/forms.css",
                      "~/Content/gallery.css",
                      "~/Content/media.css",
                      "~/Content/navigation.css",
                      "~/Content/typography.css"));
        }
    }
}
