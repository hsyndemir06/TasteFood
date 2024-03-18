using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class ProfileController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            ViewBag.v = Session["a"];
            return View();
        }  

    }
}