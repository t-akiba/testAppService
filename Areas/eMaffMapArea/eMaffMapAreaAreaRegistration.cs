using System.Web.Mvc;

namespace Tm2TestAppService.Areas.eMaffMapArea
{
    public class eMaffMapAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "eMaffMapArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "eMaffMapArea_default",
                "eMaffMapArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}