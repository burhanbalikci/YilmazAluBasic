using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using YilmazAlu.BOL.Entities;
using YilmazAlu.Repositories;

namespace YilmazAluUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        Repository<Admin> repoAdmin = new Repository<Admin>();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    string rol = "";
                    if (HttpContext.Current.User.Identity.Name[0] == '#') rol = repoAdmin.GetBy(f => f.KullaniciAdi == HttpContext.Current.User.Identity.Name.Replace("#", "")).Role;
                    else rol = repoAdmin.GetBy(f => f.KullaniciAdi == HttpContext.Current.User.Identity.Name).Role;
                    string[] roles = rol.Split(',');
                    HttpContext.Current.User = new GenericPrincipal((FormsIdentity)HttpContext.Current.User.Identity, roles);
                }
            }
        }
    }
}
