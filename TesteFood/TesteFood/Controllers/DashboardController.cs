using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;

namespace TesteFood.Controllers
{
    public class DashboardController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Products.Count();
            ViewBag.v3 = context.Chefs.Count();
            ViewBag.v4 = context.Reservations.Where(x => x.ReservationStatus == "Aktif").Count();
            
            return View();
        }

        public PartialViewResult DasboardChart()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult DashboardProgressbar()
        {
            ViewBag.v1 = context.Reservations.Count();
            ViewBag.v2 = context.Contacts.Count();
            ViewBag.v3 = context.Products.Count();
            ViewBag.v4 = context.OpenDayHours.Count();
            ViewBag.v5 = context.Testimonials.Count();
            return PartialView();
        }
    }
}