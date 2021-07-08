using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tm2TestAppService.Models;

namespace Tm2TestAppService.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            //POST処理から直接戻り値を画面に反映させる
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }

            return View(model);
        }
    }
}