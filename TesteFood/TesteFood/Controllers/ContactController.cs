using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class ContactController : Controller
    {
        TasteContext context = new TasteContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Contact p) // index degilde contact olacaktı ama olsun :)
        {
            var value = context.Contacts.Add(p);
            value.ContactName = p.ContactName;
            value.ContactEmail = p.ContactEmail;
            value.ContactSubject = p.ContactSubject;
            value.ContactMessage = p.ContactMessage;
            value.ContactSendDate = DateTime.Today;
            context.SaveChanges();
            return View();
        }

        public ActionResult PartialContact()
        {
            var values = context.Adresses.ToList();   
            return PartialView(values);
        }
    }
}