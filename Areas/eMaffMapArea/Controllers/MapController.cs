using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tm2TestAppService.Areas.eMaffMapArea.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        [HttpGet]
        public ActionResult Map()
        {
            return View();
        }
    }
}