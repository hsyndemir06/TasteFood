using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Adresses.Select(x => x.AdressPhone).FirstOrDefault();
            ViewBag.mail = context.Adresses.Select(x => x.AdressEmail).FirstOrDefault();
            ViewBag.description = context.Adresses.Select(x => x.AdressDescription).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var value = context.Abouts.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var value = context.Testimonials.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialChef()
        {
            var value = context.Chefs.ToList();
            return PartialView(value);
        } 
        
        public PartialViewResult PartialFooter()
        {
            // footerın en alt kısımdaki çalışma saatlerini cektim
            var value = context.OpenDayHours.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialNavigation()
        {
            return PartialView();
        }


    }
}