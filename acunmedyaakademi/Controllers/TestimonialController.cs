using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;


namespace acunmedyaakademi.Controllers
{

    public class TestimoinalController : Controller
    {
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();

        // GET: Testimoinal
        public ActionResult Index()

        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial p)
        {
            var value = db.TblTestimonial.Find(p.TestimonialId);
            value.TestimonialDescription = p.TestimonialDescription;
            value.TestimonialImageUrl = p.TestimonialImageUrl;
            value.TestimonialTitle = p.TestimonialTitle;
            value.TestimonialName = p.TestimonialName;
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}