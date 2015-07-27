using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using testZip.App_Start;

namespace testZip
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutofacConfig.Bootstrapper();
        }
    }
}
