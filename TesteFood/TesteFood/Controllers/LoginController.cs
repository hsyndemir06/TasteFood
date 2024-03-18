using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Entities;
using TesteFood.Context;
using System.Web.Security;

namespace TesteFood.Controllers
{
    public class LoginController : Controller
    {
        TasteContext context = new TasteContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = context.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (values != null)
            {

                FormsAuthentication.SetAuthCookie(values.UserName, true);
                Session["a"] = values.UserName;
                return RedirectToAction("AdminUrun", "Product");
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}