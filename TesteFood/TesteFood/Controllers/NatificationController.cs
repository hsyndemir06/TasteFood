using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;

namespace TesteFood.Controllers
{
    public class NatificationController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult NatificationList()
        {
            var values = context.Notifacations.ToList();
            return View(values);
        }

        public ActionResult NatificationIsReadChangToTrue(int id)
        {
            var values = context.Notifacations.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("NatificationList");
        }

        public ActionResult NatificationIsReadChangToFalse(int id)
        {
            var values = context.Notifacations.Find(id);
            values.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("NatificationList");

        }
    }
}