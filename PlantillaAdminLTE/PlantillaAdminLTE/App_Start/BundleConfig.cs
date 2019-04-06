using System.Web;
using System.Web.Optimization;

namespace PlantillaAdminLTE
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/vendors/jquery/dist/jquery.js",   
                      "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",   
                      "~/Content/vendors/fastclick/lib/fastclick.js",  
                      "~/Content/vendors/nprogress/nprogress.js",  
                      "~/Content/vendors/Chart.js/dist/Chart.js",  
                      "~/Content/vendors/gauge.js/dist/gauge.js", 
                      "~/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.js",
                      "~/Content/vendors/iCheck/icheck.js",
                      "~/Content/vendors/skycons/skycons.js", 
                      "~/Content/vendors/Flot/jquery.flot.js",
                      "~/Content/vendors/Flot/jquery.flot.pie.js",
                      "~/Content/vendors/Flot/jquery.flot.time.js",
                      "~/Content/vendors/Flot/jquery.flot.stack.js",
                      "~/Content/vendors/Flot/jquery.flot.resize.js", 
                      "~/Content/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                      "~/Content/vendors/flot-spline/js/jquery.flot.spline.js",
                      "~/Content/vendors/flot.curvedlines/curvedLines.js",
                      "~/Content/vendors/DateJS/build/date.js", 
                      "~/Content/vendors/jqvmap/dist/jquery.vmap.js",
                      "~/Content/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                      "~/Content/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                      "~/Content/vendors/moment/min/moment.js",
                      "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.js",  
                      "~/Content/build/js/custom.js" 
    
                        ));


         bundles.Add(new StyleBundle("~/Content/vendors/css").Include(
                       "~/Content/vendors/bootstrap/dist/css/bootstrap.css", 
                       "~/Content/vendors/font-awesome/css/font-awesome.css" , 
                       "~/Content/vendors/nprogress/nprogress.css", 
                       "~/Content/vendors/iCheck/skins/flat/green.css", 
                       "~/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.css", 
                       "~/Content/vendors/jqvmap/dist/jqvmap.css", 
                       "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.css",
                       "~/Content/build/css/custom.css"
                         ));

        }
        
    }
}
