using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;

namespace TesteFood.Controllers
{
    public class ChefController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            var value = context.Chefs.ToList();
            return View(value);
        }
    }
}