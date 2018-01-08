using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Web;

namespace AbpFramework
{
    public class MvcApplication : AbpWebApplication<AbpFrameworkwebModule>
    {
        protected override void Application_Start(object sender,EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            base.Application_Start(sender,e);
        }
    }
}
