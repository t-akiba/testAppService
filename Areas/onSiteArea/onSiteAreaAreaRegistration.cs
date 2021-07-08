using System.Web.Mvc;

namespace Tm2TestAppService.Areas.onSiteArea
{
    public class onSiteAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "onSiteArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "onSiteArea_default",
                "onSiteArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}