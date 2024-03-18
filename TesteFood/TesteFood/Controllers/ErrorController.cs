using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteFood.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Page404()
        {
            return View();
        }

        public ActionResult Page403()
        {
            return View();
        }

        public ActionResult Page500()
        {
            return View();
        }
    }
}