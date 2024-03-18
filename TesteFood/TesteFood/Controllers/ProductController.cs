using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class ProductController : Controller
    {
        
        TasteContext context = new TasteContext();

        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Product1()
        {
            var value = context.Products.ToList();
            return PartialView(value);
        }

        public PartialViewResult Product2()
        {
            var value = context.Urunlers.ToList();
            return PartialView(value);
        }

        public PartialViewResult Product3()
        {
            var value = context.TblUruns.ToList();
            return PartialView(value);
        }

        public ActionResult AdminUrun()
        {
            var value = context.Products.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product p)
        {
            p.ProductIsActive = true;
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("AdminUrun");
        }

        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AdminUrun");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = context.Products.Find(id);
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = categories;
            return View(value);
        }

        public ActionResult UpdateProduct(Product p)
        {
            var value = context.Products.Find(p.ProductID);
            value.CategoryID = p.CategoryID;
            value.ProductName = p.ProductName;
            value.ProductImageUrl = p.ProductImageUrl;
            value.ProductIsActive = p.ProductIsActive;
            value.ProductPrice = p.ProductPrice;
            value.ProductDescription = p.ProductDescription;
            context.SaveChanges();
            return RedirectToAction("AdminUrun");
        }
    }
}