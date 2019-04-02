using System.Web.Mvc;

namespace YilmazAluUI.Areas.Yonetim
{
    public class YonetimAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Yonetim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Yonetim_default",
                "Yonetim/{controller}/{action}/{id}",
                new { controller= "Admin", action = "Index", id = UrlParameter.Optional },
                new[] { "YilmazAluUI.Areas.Yonetim.Controllers" }
            );
        }
    }
}