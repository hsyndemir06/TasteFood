using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class CategoryController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = context.Categories.Find(id);
            return View(values);
        }


        public ActionResult UpdateCategory(Category c)
        {
            var values = context.Categories.Find(c.CategoryID);
            values.CategoryName = c.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}