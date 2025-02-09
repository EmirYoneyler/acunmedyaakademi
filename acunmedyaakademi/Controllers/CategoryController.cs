using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;

namespace acunmedyaakademi.Controllers
{
    public class CategoryController : Controller
    {
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        // GET: Category
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        public ActionResult SendMessage() //daha önce eklemişim ama neden olduğuınu çözemedim
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var value = db.TblCategory.Find(p.CategoryId);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}