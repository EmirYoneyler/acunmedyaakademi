using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  acunmedyaakademi.Models;

namespace acunmedyaakademi.Controllers
{
    public class FeatureController : Controller
    {
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        // GET: Feature
        public ActionResult Index()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
       public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
          
        public ActionResult DeleteFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            db.TblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateData(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateData(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureId);
            value.FeatureTitle = p.FeatureTitle;
            value.FetureSubtitle = p.FetureSubtitle;
            value.FeatureImageUrl = p.FeatureImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}