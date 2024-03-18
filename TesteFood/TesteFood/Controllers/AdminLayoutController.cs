using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;

namespace TesteFood.Controllers
{
    public class AdminLayoutController : Controller
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
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            ViewBag.v = Session["a"];

            ViewBag.nativationISREADfalseCount = context.Notifacations.Where(x => x.IsRead == false).Count();
            var values = context.Notifacations.Where(x => x.IsRead == false).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialNavbarMessage()
        {
            ViewBag.navbarMessage = context.Contacts.Where(x => x.IsRead == false).Count();
            var values = context.Contacts.Where(x => x.IsRead == false).ToList();
            return PartialView(values);
        }

        public ActionResult NavbarMessageTrueFalse(int id)
        {
            var values = context.Contacts.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category");
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public ActionResult NotificationStatusChangeToTrue(int id)
        {
            var values = context.Notifacations.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category");
        }

        public ActionResult AllMessage()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}