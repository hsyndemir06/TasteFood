using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;

namespace TesteFood.Controllers
{
    public class AboutController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult Index()
        {
           

            var value = context.Abouts.ToList();
            return View(value);
        }

        
    }
}