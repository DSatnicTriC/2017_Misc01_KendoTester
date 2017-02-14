using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace DanielWebApp02
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);
        }

        public static void RegisterBundles(BundleCollection bundles)
        {
            ScriptBundle debugBundle = new ScriptBundle("~/bundles/debugBundle");
            debugBundle.Include(
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/kendo.ui.core.js");
            bundles.Add(debugBundle);

            ScriptBundle releaseBundle = new ScriptBundle("~/bundles/releaseBundle");
            releaseBundle.Include(
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/kendo.ui.core.min.js");
            bundles.Add(releaseBundle);
        }
    }
}
