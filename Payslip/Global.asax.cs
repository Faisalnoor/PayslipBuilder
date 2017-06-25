using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Payslip.Helpers;


namespace Payslip
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterBundles(BundleCollection bundles)
        {
            var scripts = new ScriptBundle("~/Bundles/Scripts")
                .Include("~/Scripts/*.js");
            bundles.Add(scripts);

            var styles = new Bundle("~/Bundles/Styles",
                    new LessTransform(),
                    new CssMinify())
                .IncludeDirectory("~/Styles", "*.less");
            bundles.Add(styles);
        }
    }
}
